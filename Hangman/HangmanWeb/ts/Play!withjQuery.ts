namespace Hangman {
    //let e = await getWord(7);
    //console.log(e);

    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    var graphql = JSON.stringify({
        query: "",
        variables: {}
    })
    var requestOptions: any = {
        method: 'GET',
        headers: myHeaders,
        //body: graphql,
        redirect: 'follow'
    };
    async function getWord(length: number) {
        let word;
        try {
            let url = "https://random-word-api.herokuapp.com/word?";
            let params = new URLSearchParams();
            params.append("length", length.toString());
            let r = await fetch(url + params.toString(), requestOptions);
            let p = await r.json();
            word = p[0];
        }
        catch (e) {
            console.log(e.message);
        }
        return word;
    }
    const notStarted = "Click Pick a Word to start the game!";
    const justStarted = "Take a guess!";
    const guessed = "Woohoo! You got it! Keep going!";
    const missed = "Oh, no! Try another one.";
    const lost = "Mr. Hangman is dead.";
    const won = '"You saved my life!"';
    const gaveUp = "You'll get it next time. Click Pick a Word for a new challenge."
    let gameStatus = notStarted;

    let msg: Element;
    let letterboxes: Element[] = [];
    let letterbuttons: Element[] = [];
    let iGiveUpButton: Element;
    let pickAWordButton: Element;

    let pictureNumber = 0;

    let word: string;
    let letter1: string;
    let letter2: string;
    let letter3: string;
    let letter4: string;
    let letter5: string;
    let letter6: string;
    let letter7: string;



    $(document).ready(function () {
        msg = document.querySelector("#msg");
        letterboxes = [...document.querySelectorAll(".letterbox")];
        letterbuttons = [...$(".letterbutton")];
        iGiveUpButton = document.querySelector("#iGiveUp");
        pickAWordButton = document.querySelector("#pickAWord");
        $(pickAWordButton).click(startGame);
        $(iGiveUpButton).click(iGiveUp);
        $(letterbuttons).click(guessALetter);
        displayMessage();
        changePicture();
    })

    async function startGame() {
        pictureNumber = 0;
        changePicture();
        $(letterboxes).removeClass("text-warning").removeClass("text-black");
        gameStatus = justStarted;
        displayMessage();

        //async ()=> word = await getWord(7).toString();

        word = await getWord(7);// "parties";//e;
        letter1 = word.substring(0, 1);
        letter2 = word.substring(1, 2);
        letter3 = word.substring(2, 3);
        letter4 = word.substring(3, 4);
        letter5 = word.substring(4, 5);
        letter6 = word.substring(5, 6);
        letter7 = word.substring(6, 7);

        let wordletters = [letter1, letter2, letter3, letter4, letter5, letter6, letter7];

        letterboxes[0].textContent = letter1;
        letterboxes[1].textContent = letter2;
        letterboxes[2].textContent = letter3;
        letterboxes[3].textContent = letter4;
        letterboxes[4].textContent = letter5;
        letterboxes[5].textContent = letter6;
        letterboxes[6].textContent = letter7;

        $(letterbuttons).removeAttr("disabled");
        $(iGiveUpButton).removeAttr("disabled");
        $(pickAWordButton).attr("disabled");
        
    }

    function guessALetter(event: any) {
        let triedletter = event.target;
        triedletter.setAttribute("disabled", true);
        let guessedLetterList = [...letterboxes.filter(s => s.textContent == triedletter.textContent)];
        $(guessedLetterList).addClass("text-black");
        if (guessedLetterList.length > 0) {
            gameStatus = guessed;
        }
        else {
            gameStatus = missed;
            changePicture();
        }
        detectWinnerLoser();
        displayMessage();

    }

    function detectWinnerLoser() {
        let guessedLettersList = [...letterboxes.filter(b => b.matches(".text-black"))];
        if (guessedLettersList.length > 6) {
            gameStatus = won;
        }
        if (pictureNumber == 8) {
            gameStatus = lost;
            let unguessedLetterList = [...letterboxes.filter(b => b.classList.contains("text-primary"))];
            $(unguessedLetterList).addClass("text-warning");
        }
        if (gameStatus == won || gameStatus == lost) {
            $(letterbuttons).attr("disabled");
            $(iGiveUpButton).attr("disabled");
            $(pickAWordButton).removeAttr("disabled");
        }
    }

    function iGiveUp() {
        $(letterboxes).addClass("text-black");
        detectWinnerLoser();
        gameStatus = gaveUp;
        displayMessage();
    }

    function changePicture() {
        $("#image").attr("src", `/images/h${pictureNumber}mistake.gif`);
        pictureNumber++;
    }

    function displayMessage() {
        $(msg).text(gameStatus);
    }
}
