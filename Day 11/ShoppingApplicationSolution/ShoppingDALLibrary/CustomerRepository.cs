﻿using ShoppingApplicationModelLibrary.Exceptions;
using ShoppingApplicationModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDALLibrary
{
    public class CustomerRepository : AbstractRepository<int, Customer>
    {
        public override Customer Delete(int key) 
        {
            Customer customer = GetByKey(key);
            if (customer != null)
            {
                items.Remove(customer);
                return customer;
            }
            throw new NoCustomerWithGiveIdException();
        }

        public override Customer GetByKey(int key)
        {
            Customer customer = items.ToList().Find((c) => c.Id == key);
            if (customer != null)
            {
                return customer;
            }
            throw new NoCustomerWithGiveIdException();
        }

        public override Customer Update(Customer item)
        {
            Customer customer = GetByKey(item.Id);
            if (customer != null)
            {
                customer = item;
                return customer;
            }
            throw new NoCustomerWithGiveIdException();
        }
    }
}
