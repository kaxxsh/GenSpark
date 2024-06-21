const users = [
  { username: "user1", password: "password1" },
  { username: "user2", password: "password2" },
];

function validateLogin(username, password) {
  return users.some(
    (user) => user.username === username && user.password === password
  );
}

if (typeof document !== "undefined") {
  document
    .getElementById("loginForm")
    .addEventListener("submit", function (event) {
      event.preventDefault();

      const username = document.getElementById("username").value;
      const password = document.getElementById("password").value;

      const isValid = validateLogin(username, password);
      const messageElement = document.getElementById("message");

      if (isValid) {
        messageElement.textContent = "Login successful!";
        messageElement.style.color = "green";
      } else {
        messageElement.textContent = "Invalid username or password.";
        messageElement.style.color = "red";
      }
    });
}

module.exports = { validateLogin };
