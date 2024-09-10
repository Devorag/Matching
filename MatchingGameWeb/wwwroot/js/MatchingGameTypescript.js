const allSquares = Array.from(document.querySelectorAll(".square"));
const icons = ["🍎", "🍌", "🍇", "🍓", "🍎", "🍌", "🍇", "🍓", "🍍", "🍉", "🍒", "🍋", "🍍", "🍉", "🍒", "🍋"];
let firstClicked = null;
let secondClicked = null;
let gameStarted = false;
let processingTurn = false;
function startGame() {
    gameStarted = true;
    shuffleIcons();
    resetBoard();
    allSquares.forEach(sq => sq.addEventListener("click", handleSquareClick));
}
function shuffleIcons() {
    icons.sort(() => Math.random() - .5);
}
function resetBoard() {
    allSquares.forEach(sq => {
        sq.textContent = "";
        sq.classList.remove("matched");
        sq.disabled = false;
    });
    resetTurn();
}
function handleSquareClick(event) {
    if (!gameStarted || processingTurn)
        return;
    const target = event.target;
    if (target.classList.contains("matched") || target === firstClicked)
        return;
    const index = allSquares.indexOf(target);
    target.textContent = icons[index];
    if (!firstClicked) {
        firstClicked = target;
    }
    else {
        secondClicked = target;
        processingTurn = true;
        checkMatch();
    }
}
function checkMatch() {
    if (firstClicked.textContent === secondClicked.textContent) {
        firstClicked.classList.add("matched");
        secondClicked.classList.add("matched");
        resetTurn();
        checkGameComplete();
    }
    else {
        setTimeout(() => {
            if (firstClicked && secondClicked) {
                firstClicked.textContent = "";
                secondClicked.textContent = "";
            }
            resetTurn();
        }, 1000);
    }
}
function resetTurn() {
    firstClicked = null;
    secondClicked = null;
    processingTurn = false;
}
function checkGameComplete() {
    if (allSquares.every(sq => sq.classList.contains("matched"))) {
        setTimeout(() => {
            Swal.fire({
                title: 'Game Over',
                text: "Congratulations! You've matched all the cards!",
                icon: 'success',
                confirmButtonText: 'OK'
            });
        }, 100);
    }
}
//# sourceMappingURL=MatchingGameTypescript.js.map