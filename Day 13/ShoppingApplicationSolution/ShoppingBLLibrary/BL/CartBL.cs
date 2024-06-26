﻿using ShoppingApplicationModelLibrary;
using ShoppingApplicationModelLibrary.Exceptions;
using ShoppingBLLibrary.Services;
using ShoppingDALLibrary;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace ShoppingBLLibrary.BL
{
    public class CartBL : ICartService
    {

        private const double SHIPPING_CHARGE = 100.00;
        private const double DISCOUNT_PERCENTAGE = 0.05;
        readonly IRepository<int, Cart> _cartRepository;
        readonly IRepository<int, CartItem> _cartItemRepository;
        readonly IRepository<int, Product> _productRepository;


        private readonly IProductService _productService;
        private readonly ICartItemService _cartItemService;

        [ExcludeFromCodeCoverage]
        public CartBL()
        {
            _cartRepository = new CartRepository();
        }
        [ExcludeFromCodeCoverage]
        public CartBL(IRepository<int, Cart> repository)
        {
            _cartRepository = repository;
        }

        [ExcludeFromCodeCoverage]
        public CartBL(IRepository<int, Cart> cartRepository, IRepository<int, CartItem> cartItemRepository, IRepository<int, Product> productRepository)
        {
            _cartRepository = cartRepository;
            _cartItemRepository = cartItemRepository;
            _productRepository = productRepository;

        }
        [ExcludeFromCodeCoverage]
        public CartBL(IProductService productService, ICartItemService cartItemService)
        {
            _cartRepository = new CartRepository();
            _productService = productService;
            _cartItemService = cartItemService;
        }


        public async Task<int> AddCart(Cart cart)
        {

            // Apply shipping charges, discounts, and check maximum quantities
            ProccessCart(cart);

            Cart addedCart = await _cartRepository.Add(cart);
            if (addedCart == null)
            {
                throw new NoCartWithGivenIdException();
            }
            foreach (var cartItem in cart.CartItems)
            {
                cartItem.Product.QuantityInHand -= cartItem.Quantity;
                //_productService.UpdateProduct(cartItem.Product);
            }

            return addedCart.Id;
        }

        public async Task<Cart> DeleteCart(int id)
        {

            Cart deletedCart = await _cartRepository.Delete(id);
            if (deletedCart == null)
            {
                throw new CartNotFoundException();
            }

            return deletedCart;
        }

        public async Task<List<Cart>> GetAllCarts()
        {
            var carts = await _cartRepository.GetAll();
            if (carts.Count == 0)
            {
                throw new CartNotFoundException();
            }
            return carts.ToList();
        }

        public async Task<Cart> GetCartById(int id)
        {
            Cart cart = await _cartRepository.GetByKey(id);
            if (cart == null)
            {
                throw new CartNotFoundException();
            }
            return cart;
        }

        public async Task<Cart> UpdateCart(Cart cart)
        {
            if (cart == null)
            {
                throw new ArgumentNullException(nameof(cart), "Cart cannot be null.");
            }

            // Apply shipping charges, discounts, and check maximum quantities
            ProccessCart(cart);

            // Update the cart in the repository
            Cart updatedCart = await _cartRepository.Update(cart);
            if (updatedCart == null)
            {
                throw new CartNotFoundException();
            }
            return updatedCart;
        }

        [ExcludeFromCodeCoverage]
        private void ProccessCart(Cart cart)
        {
            // Calculate total price by summing up prices of cart items
            double totalPrice = 0;
            foreach (var item in cart.CartItems)
            {
                totalPrice += item.Price;
            }

            // Add shipping charge if total price is less than 100
            if (totalPrice < 100)
            {
                totalPrice += SHIPPING_CHARGE; // Add shipping charge
            }

            // Apply discount if cart has 3 items and total price is 1500 or more
            if (cart.CartItems.Count == 3 && totalPrice >= 1500)
            {
                totalPrice -= totalPrice * DISCOUNT_PERCENTAGE; // Apply 5% discount
            }

            // Check maximum quantity of any product in the cart
            foreach (var item in cart.CartItems)
            {
                if (item.Quantity > 5)
                {
                    throw new ArgumentException($"Maximum quantity of products in cart cannot be more than 5.");
                }
            }

            // Update the total price in the cart
            cart.TotalPrice = totalPrice;
        }
    }
}
