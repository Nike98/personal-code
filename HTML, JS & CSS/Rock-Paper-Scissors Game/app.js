let user_score = 0;
let computer_score = 0;
const userScore_span = document.getElementById("user-score");
const computerScore_span = document.getElementById("comp-score");
const scoreBoard_div = document.querySelector(".score-board");
const result_div_p = document.querySelector(".result > p");
const rock_div = document.getElementById("rock");
const paper_div = document.getElementById("paper");
const scissor_div = document.getElementById("scissor");

function getComputerChoice() {
    const choices = ['rock', 'paper', 'scissor'];
    const randomChoice = Math.floor(Math.random() * 3);
    return choices[randomChoice];
    console.log(choices);
}

function convertToWord(word) {
    if (word === "rock") return "Rock";
    if (word === "paper") return "Paper";
    if (word === "scissor" || word === "scissors") return "Scissor";
}

function win(usrChoice, compChoice) {
    const smallUserWord = "user".fontsize(3).sub();
    const smallCompWord = "comp".fontsize(3).sub();
    const userChoice_div = document.getElementById(usrChoice);
    user_score++;
    userScore_span.innerHTML = user_score;
    computerScore_span.innerHTML = computer_score;
    result_div_p.innerHTML = `${convertToWord(usrChoice)}${smallUserWord} beats ${convertToWord(compChoice)}${smallCompWord}. You Win! 🔥`;
    userChoice_div.classList.add('green-glow');
    setTimeout(() => userChoice_div.classList.remove('green-glow'), 500); 
}

function lose(usrChoice, compChoice) {
    const smallUserWord = "user".fontsize(3).sub();
    const smallCompWord = "comp".fontsize(3).sub();
    const userChoice_div = document.getElementById(usrChoice);
    computer_score++;
    userScore_span.innerHTML = user_score;
    computerScore_span.innerHTML = computer_score;
    result_div_p.innerHTML = `${convertToWord(usrChoice)}${smallUserWord} loses to ${convertToWord(compChoice)}${smallCompWord}. You Lost... 💩💩`;
    userChoice_div.classList.add('red-glow');
    setTimeout(() => userChoice_div.classList.remove('red-glow'), 500);
}

function draw(usrChoice, compChoice) {
    const smallUserWord = "user".fontsize(3).sub();
    const smallCompWord = "comp".fontsize(3).sub();
    const userChoice_div = document.getElementById(usrChoice);
    userScore_span.innerHTML = user_score;
    computerScore_span.innerHTML = computer_score;
    result_div_p.innerHTML = `${convertToWord(usrChoice)}${smallUserWord} equals ${convertToWord(compChoice)}${smallCompWord}. It's a Draw`;
    userChoice_div.classList.add('gray-glow');
    setTimeout(() => userChoice_div.classList.remove('gray-glow'), 500);
}

function game(userChoice) {
    const computerChoice = getComputerChoice();
    switch (userChoice + computerChoice) {
        case "rockscissor":
        case "paperrock":
        case "scissorpaper":
            win(userChoice, computerChoice);
            break;

        case "rockpaper":
        case "paperscissor":
        case "scissorrock":
            lose(userChoice, computerChoice);
            break;

        case "rockrrock":
        case "paperpaper":
        case "scissorscissor":
            draw(userChoice, computerChoice);
            break;
    }
}

function main() {
    rock_div.addEventListener('click', () => game("rock"));

    paper_div.addEventListener('click', () => game("paper"));

    scissor_div.addEventListener('click', () => game("scissor"));
}

main();