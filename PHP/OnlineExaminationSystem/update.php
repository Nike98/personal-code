<?php
include_once 'dbConnection.php';
session_start();
$email = $_SESSION['email'];

                // ****** DELETE SECTION ******

// DELETE FEEDBACK
if (isset($_SESSION['key'])){
    if (@$_GET['fdid'] && $_SESSION['key'] == 'nikhil9595228822'){
        $id = @$_GET['fdid'];
        $result = mysqli_query($con, "DELETE FROM feedback WHERE id='$id'") or die('Error');
        header("location:dash.php?q=3");
    }
}

// DELETE USER
if (isset($_SESSION['key'])){
    if (@$_GET['del_email'] && $_SESSION['key'] == 'nikhil9595228822'){
        $del_email = @$_GET['del_email'];
        $from_rank = mysqli_query($con, "DELETE FROM rank WHERE email='$del_email'") or die('Error');
        $from_history = mysqli_query($con, "DELETE FROM history WHERE email='$del_email'") or die('Error');
        $from_user = mysqli_query($con, "DELETE FROM user WHERE email='$del_email'") or die('Error');
        header("location:dash.php?q=1");
    }
}

// REMOVE QUIZ
if (isset($_SESSION['key'])){
    if (@$_GET['q'] == 'rem_quiz' && $_SESSION['key'] == 'nikhil9595228822'){
        $eid = @$_GET['eid'];
        $result = mysqli_query($con, "SELECT * FROM questions WHERE eid='$eid'")or die('Error');
        while ($row = mysqli_fetch_array($result)){
            $quid = $row['qid'];
            $from_options = mysqli_query($con, "DELETE FROM options WHERE qid='$qid'") or die('Error');
            $from_answers = mysqli_query($con, "DELETE FROM answer WHERE qid='$qid'") or die('Error');
        }
        $from_questions = mysqli_query($con, "DELETE FROM questions WHERE eid='$eid'") or die('Error');
        $from_quiz = mysqli_query($con, "DELETE FROM quiz WHERE eid='$eid'") or die('Error');
        $from_history = mysqli_query($con, "DELETE FROM history WHERE eid='$eid'") or die('Error');

        header("location:dash.php?q=5");
    }
}

                // ****** ADDITION SECTION ******

// ADD QUIZ
if (isset($_SESSION['key'])){
    if (@$_GET['q'] == 'addquiz' && $_SESSION['key'] == 'nikhil9595228822'){
        $name = $_POST['name'];
        $name = ucwords(strtolower($name));
        $total = $_POST['total'];
        $sahi = $_POST['right'];
        $wrong = $_POST['wrong'];
        $time = $_POST['time'];
        $tag = $_POST['tag'];
        $desc = $_POST['desc'];
        $id = uniqid();
        $add_quiz_query = mysqli_query($con, "INSERT INTO quiz VALUES 
                            ('$id', '$name', '$sahi', '$wrong', '$total', '$time', '$desc', '$tag', NOW())");

        header("location:dash.php?q=4&step=2&eid=$id&n=$total");
    }
}

// ADD QUESTION
if (isset($_SESSION['key'])){
    if (@$_GET['q'] == 'addqns' && $_SESSION['key'] == 'nikhil9595228822'){
        $n = $_GET['n'];
        $eid = @$_GET['eid'];
        $ch = @$_GET['ch'];

        for ($i = 1 ; $i <= $n ; $i++){
            $qid = uniqid();
            $qns = $_POST['qns'.$i];

            $add_question_query = mysqli_query($con, "INSERT INTO questions VALUES ('$eid', '$qid', '$qns', '$ch', '$i')");

            $oaid = uniqid();
            $obid = uniqid();
            $ocid = uniqid();
            $odid = uniqid();

            $a = $_POST[$i.'1'];
            $b = $_POST[$i.'2'];
            $c = $_POST[$i.'3'];
            $d = $_POST[$i.'4'];

            $qa = mysqli_query($con, "INSERT INTO options VALUES ('$qid', '$a', '$oaid')") or die('Error61');
            $qb = mysqli_query($con, "INSERT INTO options VALUES ('$qid', '$b', '$obid')") or die('Error62');
            $qc = mysqli_query($con, "INSERT INTO options VALUES ('$qid', '$c', '$ocid')") or die('Error63');
            $qd = mysqli_query($con, "INSERT INTO options VALUES ('$qid', '$d', '$ocid')") or die('Error64');

            $e = $_POST['ans'.$i];

            switch ($e){
                case 'a':
                    $ansid = $oaid;
                    break;
                case 'b':
                    $ansid = $obid;
                    break;
                case 'c':
                    $ansid = $ocid;
                    break;
                case 'd':
                    $ansid = $odid;
                    break;
                default:
                    $ansid = $oaid;
            }
            $qans = mysqli_query($con, "INSERT INTO answer VALUES ('$qid', '$ansid')");
        }
        header("location:dash.php?q=0");
    }
}

// QUIZ START
if (@$_GET['q'] == 'quiz' && @$_GET['step'] == 2) {
    $eid = @$_GET['eid'];
    $s_no = @$_GET['n'];
    $total = @$_GET['total'];
    $ans = $_POST['ans'];
    $qid = @$_GET['qid'];

    $query = mysqli_query($con, "SELECT * FROM answer WHERE qid='$qid'");
    while ($row = mysqli_fetch_array($query)) {
        $sahi = $row['sahi'];
    }

    if ($s_no == 1){
        $history_insert_query = mysqli_query($con, "INSERT INTO history VALUES 
                                  ('$email', '$eid', '0', '0', '0', '0', NOW())") or die('Error');

        $history_select = mysqli_query($con, "SELECT * FROM history WHERE eid='$eid' AND email='$email'") or die('Error115');

        while ($row = mysqli_fetch_array($history_select)) {
            $score = $row['score'];
            $right_answer = $row['sahi'];
        }

        $right_answer++;
        $score = $score + $sahi;

        $history_update = mysqli_query($con, "UPDATE 'history' SET 'score'=$score, 'level'=$s_no, 'sahi'=$right_answer, date=NOW()
                        WHERE email='$email' AND eid='$eid'") or die('Error124');
    }
    else {
        $fetch_quiz = mysqli_query($con, "SELECT * FROM quiz WHERE eid='$eid'") or dir('Error129');

        while ($row = mysqli_fetch_array($fetch_quiz))
            $wrong = $row['wrong'];

        if ($s_no == 1)
            $query = mysqli_query($con, "INSERT INTO history VALUES ('$email', '$eid', '0', '0', '0', '0', NOW())") or die('Error137');

        $fetch_history = mysqli_query($con, "SELECT * FROM history WHERE eid='$eid' AND email='$email'")or die('Error139');

        while ($row = mysqli_fetch_array($fetch_history)){
            $score = $row['score'];
            $wrong = $row['wrong'];
        }
        $wrong++;
        $score = $score - $wrong;

        $update_history = mysqli_query($con, "UPDATE 'history' SET 'score'=$score, 'level'=$s_no, 'wrong'=$wrong, date=NOW()
                            WHERE email='$email' AND eid='$eid'") or die('Error147');
    }
    if ($s_no != $total){
        $s_no++;
        header("location:account.php?q=quiz&step=2&eid=$eid&n=$s_no&t=$total") or die('Error152');
    }
    else if ($_SESSION['key'] != 'nikhil9595228822'){
        $fetch_score_history = mysqli_query($con, "SELECT score FROM history WHERE eid='$eid' AND email='$email'") or die('Error156');
        while ($row = mysqli_fetch_array($fetch_score_history))
            $score = $row['score'];

        $fetch_rank = mysqli_query($con, "SELECT * FROM rank WHERE  email='$email'") or die('Error161');
        $rowcount = mysqli_num_rows($fetch_rank);
        if ($rowcount == 0)
            $insert_rank = mysqli_query($con, "INSERT INTO rank VALUES('$email', '$score', NOW())") or die('Error165');
        else{
            while ($row = mysqli_fetch_array($fetch_rank))
                $sum = $row['score'];
            $sum = $score + $sum;
            $update_rank = mysqli_query($con, "UPDATE 'rank' SET 'score'=$sum, 'time'=NOW() WHERE 'email'=$email") or die('Error174');
        }
        header("location:account.php?q=result&eid=$eid");
    }
    else
        header("location:account.php?q=result&eid=$eid");
}

// RESTART QUIZ
if (@$_GET['q'] == 'requiz' && @$_GET['step'] == 25){
    $eid = @$_GET[['eid']];
    $n = @$_GET[['n']];
    $t = @$_GET[['t']];

    $fetch_score_history = mysqli_query($con, "SELECT score FROM history WHERE eid='$eid' AND email='$email'") or die('Error156');

    while ($row = mysqli_fetch_array($fetch_score_history))
        $score = $row['score'];

    $query = mysqli_query($con, "DELETE FROM 'history' WHERE 'eid'=$eid AND 'email'=$email") or die('Error184');
    $query = mysqli_query($con, "SELECT * FROM rank WHERE email='$email'") or die('Error161');

    while ($row = mysqli_fetch_array($query))
        $sum = $row['score'];

    $sum = $sum - $score;

    $update_rank = mysqli_query($con, "UPDATE 'rank' SET 'score'=$sum, 'time'=NOW() WHERE 'email'=$email") or die('Error174');

    header("location:account.php?q=quiz&step=2&eid=$eid&n=1&t=$t");
}
?>