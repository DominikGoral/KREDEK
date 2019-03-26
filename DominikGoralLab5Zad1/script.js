// Rozpoczęcie pomiaru czasu
var startTime = 0;
// Zakończenie pomiaru czasu
var endTime = 0;
// Czas trwania testu
var testTime = 0;
// Obecny indeks pytania
var currentQuestion = 0;
// wynik
var score = 0;
// odpowiedź
var answer = 0;
function Start(){
	var startTime = new Date().getTime();
	LoadQuestion(0);
}
// funkcja ładująca nam pytania i odpowiedzi
function LoadQuestion(questionIndex){
	// obecne pytanie
	var singleQuestion = questions[questionIndex];
	// ładujemy pytanie i odpowiedzi do naszej storny
	document.getElementById("interiorQuestion").innerHTML = singleQuestion.question;
	document.getElementById("choice0").innerHTML = singleQuestion.option1;
	document.getElementById("choice1").innerHTML = singleQuestion.option2;
	document.getElementById("choice2").innerHTML = singleQuestion.option3;
	document.getElementById("choice3").innerHTML = singleQuestion.option4;
};
// odpowiedź w przypadku kliknięcia pierwszego przycisku
function FirstAnswer(){
	answer = 1;
};
// odpowiedź w przypadku kliknięcia drugiego przycisku
function SecondAnswer(){
	answer = 2;
};
// odpowiedź w przypadku kliknięcia trzeciego przycisku
function ThirdAnswer(){
	answer = 3;
};
// odpowiedź w przypadku kliknięcia czwartego przycisku
function FourthAnswer(){
	answer = 4;
};
// funckja dodająca nam punkty i ustalająca czy możemy załadować kolejne pytanie
function CheckAnswer(){
	if(answer == 0){
		alert('Please select your answer!');
		answer=0;
		return;
	}
	if(questions[currentQuestion].answer == answer){
		score++;
	}
	answer=0;
	// jeśli mamy przedostatnie pytanie zmieniamy wartość przycisku ,, następne"
	if(currentQuestion == questions.length - 2){
		document.getElementById('nextQuestion').textContent = 'Finish';
	}
	// jeśli mamy ostatnie pytanie pokazujemy wyniki
	if(currentQuestion == questions.length-1){
		endTime = new Date().getTime();
		testTime = endTime - startTime;
		alert("Your score: " + score + "\n" + "Your time: " + testTime);
		return;
	}
	currentQuestion++;
	LoadQuestion(currentQuestion);
}