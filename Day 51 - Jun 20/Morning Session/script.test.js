const { validateLogin } = require("./script");

test("valid login with correct credentials", () => {
  expect(validateLogin("user1", "password1")).toBe(true);
  expect(validateLogin("user2", "password2")).toBe(true);
});

test("invalid login with incorrect username", () => {
  expect(validateLogin("invalidUser", "password1")).toBe(false);
  expect(validateLogin("invalidUser", "password2")).toBe(false);
});

test("invalid login with incorrect password", () => {
  expect(validateLogin("user1", "wrongPassword")).toBe(false);
  expect(validateLogin("user2", "wrongPassword")).toBe(false);
});

test("invalid login with both incorrect username and password", () => {
  expect(validateLogin("invalidUser", "wrongPassword")).toBe(false);
});
