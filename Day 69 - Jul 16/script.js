const words = [
  "rossa",
  "jetty",
  "wizzo",
  "cuppa",
  "cohoe",
  "gurks",
  "squad",
  "beisa",
  "shrug",
  "fossa",
  "fluyt",
  "camus",
  "speed",
  "mamil",
  "array",
  "polio",
  "barns",
  "panes",
  "souts",
  "limas",
  "fetch",
  "queck",
  "twink",
  "graze",
  "crock",
  "almud",
  "oohed",
  "colog",
  "wisht",
  "beard",
  "samel",
  "ahind",
  "brung",
  "barca",
  "mahal",
  "jambe",
  "plush",
  "bruja",
  "howre",
  "middy",
  "kabab",
  "zeals",
  "mazel",
  "sputa",
  "goory",
  "pails",
  "scogs",
  "snool",
  "poboy",
  "doest",
];
let secretWord = words[Math.floor(Math.random() * words.length)];
let currentRow = 0;
let currentGuess = "";

const grid = document.getElementById("grid");
const keyboard = document.getElementById("keyboard");
const message = document.getElementById("message");

function createGrid() {
  for (let i = 0; i < 6; i++) {
    for (let j = 0; j < 5; j++) {
      const cell = document.createElement("div");
      cell.classList.add("cell");
      cell.id = `cell-${i}-${j}`;
      grid.appendChild(cell);
    }
  }
}

function handleKeyPress(letter) {
  if (currentGuess.length < 5) {
    currentGuess += letter;
    updateGrid();
  }
}

function handleEnter() {
  if (currentGuess.length === 5) {
    checkGuess();
    currentGuess = "";
    currentRow++;
    if (currentRow === 6) {
      endGame(false);
    }
  }
}

function updateGrid() {
  for (let i = 0; i < 5; i++) {
    const cell = document.getElementById(`cell-${currentRow}-${i}`);
    cell.textContent = currentGuess[i] || "";
  }
}

function checkGuess() {
  let correct = 0;
  for (let i = 0; i < 5; i++) {
    const cell = document.getElementById(`cell-${currentRow}-${i}`);
    const letter = currentGuess[i];
    if (letter === secretWord[i]) {
      cell.classList.add("correct");
      highlightKey(letter, "correct");
      correct++;
    } else if (secretWord.includes(letter)) {
      cell.classList.add("present");
      highlightKey(letter, "present");
    } else {
      cell.classList.add("absent");
      highlightKey(letter, "absent");
    }
  }
  if (correct === 5) {
    endGame(true);
  }
}

function highlightKey(letter, status) {
  const key = keyboard.querySelector(`[data-key="${letter}"]`);
  key.classList.remove("correct", "present", "absent");
  key.classList.add(status);
}

function endGame(win) {
  if (win) {
    message.textContent = "Congratulations! You've guessed the word!";
  } else {
    message.textContent = `Game over! The word was ${secretWord}`;
  }
  keyboard.innerHTML = "";
}

function handleBackspace() {
  currentGuess = currentGuess.slice(0, -1);
  updateGrid();
}

function handleInput(event) {
  const letter = event.key.toLowerCase();
  if (letter === "enter") {
    handleEnter();
  } else if (letter === "backspace") {
    handleBackspace();
  } else if (/^[a-z]$/.test(letter)) {
    handleKeyPress(letter);
  }
}

document.addEventListener("keydown", handleInput);

keyboard.addEventListener("click", (event) => {
  const key = event.target.dataset.key;
  if (key === "Enter") {
    handleEnter();
  } else if (key === "Backspace") {
    handleBackspace();
  } else if (key) {
    handleKeyPress(key);
  }
});

createGrid();
