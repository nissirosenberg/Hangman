var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var Hangman;
(function (Hangman) {
    //let e = await getWord(7);
    //console.log(e);
    //var myHeaders = new Headers();
    //myHeaders.append("Content-Type", "application/json");
    //var graphql = JSON.stringify({
    //    query: "",
    //    variables: {}
    //})
    //var requestOptions: any = {
    //    method: 'GET',
    //    headers: myHeaders,
    //    /*body: graphql,*/
    //    redirect: 'follow'
    //};
    //async function getWord(length: number) {
    //    let word;
    //    try {
    //        let url = "https://random-word-api.herokuapp.com/word?";
    //        let params = new URLSearchParams();
    //        params.append("length", length.toString());
    //        let r = await fetch(url + params.toString(), requestOptions);
    //        let p = await r.json();
    //        word = p[0];
    //    }
    //    catch (e) {
    //        console.log(e.message);
    //    }
    //    return word;
    //}
    //let f = await getWords(50, 7);
    //console.log(f);
    const options = {
        method: 'GET',
        headers: {
            'x-rapidapi-key': '65e7f85401mshad1a54cb18a19aep1d6b59jsn8e2a3e1e43ff',
            'x-rapidapi-host': 'word-generator2.p.rapidapi.com'
        }
    };
    function getWords(count, length) {
        return __awaiter(this, void 0, void 0, function* () {
            let wordlist;
            try {
                let url = 'https://word-generator2.p.rapidapi.com/?';
                let params = new URLSearchParams();
                params.append("count", count.toString());
                params.append("length", length.toString());
                let response = yield fetch(url + params.toString(), options);
                let result = yield response.json();
                wordlist = result.body;
            }
            catch (error) {
                console.log(error.message);
            }
            return wordlist;
        });
    }
    const notStarted = "Click Pick a Word to start the game!";
    const justStarted = "Take a guess!";
    const guessed = "Woohoo! You got it! Keep going!";
    const missed = "Oh, no! Try another one.";
    const lost = "Mr. Hangman is dead.";
    const won = '"You saved my life!"';
    const gaveUp = "You'll get it next time. Click Pick a Word for a new challenge.";
    let gameStatus = notStarted;
    let msg;
    let letterboxes = [];
    let letterbuttons = [];
    let iGiveUpButton;
    let pickAWordButton;
    let pictureNumber = 0;
    let word;
    let letter1;
    let letter2;
    let letter3;
    let letter4;
    let letter5;
    let letter6;
    let letter7;
    let f;
    $(document).ready(function () {
        return __awaiter(this, void 0, void 0, function* () {
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
            f = yield getWords(50, 7);
            console.log(f);
        });
    });
    function startGame() {
        return __awaiter(this, void 0, void 0, function* () {
            pictureNumber = 0;
            changePicture();
            $(letterboxes).removeClass("text-warning").removeClass("text-black");
            gameStatus = justStarted;
            displayMessage();
            //async ()=> word = await getWord(7).toString();
            //let f = await getWords(50, 7);
            //console.log(f);
            //word = await getWord(7);// "parties";//e;
            let random = (Math.floor(Math.random() * 50));
            word = f[random];
            console.log(random);
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
        });
    }
    function guessALetter(event) {
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
})(Hangman || (Hangman = {}));
//# sourceMappingURL=Play!withjQuery.js.map