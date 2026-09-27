using True_false;

LoaderOfQuestion loader = new LoaderOfQuestion();
AnswerEnter answerEnter = new AnswerEnter();
Comparison comparison = new Comparison();

GameManager gameManager = new GameManager(
    loader,
    answerEnter,
    comparison
);

gameManager.Start();
