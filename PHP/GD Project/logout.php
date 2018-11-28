<?php

    session_start();
    
    unset($_SESSION['loggeIn']);
    session_destroy();
    header('Location: index.php');
    exit();

?>