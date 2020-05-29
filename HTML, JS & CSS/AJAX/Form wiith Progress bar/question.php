<?php

$ques_no = $_GET['q'];
$questions = array(
    "What is your nick/pet name?",
    "What is your Email-ID?",
    "What is your Age?",
    "What was the name of your first car?"
);

echo $questions[$ques_no];
