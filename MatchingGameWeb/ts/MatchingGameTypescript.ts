

const allSquares: HTMLButtonElement[] = Array.from(document.querySelectorAll<HTMLButtonElement>(".square"));
const icons : string[] = ["🍎", "🍌", "🍇", "🍓", "🍎", "🍌", "🍇", "🍓", "🍍", "🍉", "🍒", "🍋", "🍍", "🍉", "🍒", "🍋"];
let firstClicked: HTMLButtonElement | null = null;
let secondClicked: HTMLButtonElement | null = null;
let gameStarted: boolean = false;
let processingTurn: boolean = false;

function startGame() {
    gameStarted = true;
    shuffleIcons();
    resetBoard();
    allSquares.forEach(sq => sq.addEventListener("click", handleSquareClick));
}

function shuffleIcons() {
    icons.sort(() => Math.random() - .5);
}

function resetBoard(): void{
    allSquares.forEach(sq => {
        sq.textContent = "";
        sq.classList.remove("matched");
        sq.disabled = false;
    });
    resetTurn();
}

function handleSquareClick(event: MouseEvent) {
    if (!gameStarted || processingTurn) return;
    const target = event.target as HTMLButtonElement;
    if (target.classList.contains("matched") || target === firstClicked) return;
    const index: number = allSquares.indexOf(target);
    target.textContent = icons[index];

    if (!firstClicked) {
        firstClicked = target;
    } else {
        secondClicked = target;
        processingTurn = true;
        checkMatch();
    }
}

function checkMatch(): void {
    if (firstClicked.textContent === secondClicked.textContent) {
        firstClicked.classList.add("matched");
        secondClicked.classList.add("matched");
        resetTurn();
        checkGameComplete();
    } else {
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

function checkGameComplete(): void {
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