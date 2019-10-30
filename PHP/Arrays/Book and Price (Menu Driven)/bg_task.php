<?php
    $book_arr = array("PHP Objects, Patterns and Practise (Paperback) by Matt Zandstra" => "$30",
                 "Programming PHP (Paperback) by Rasmus Lerdorf" => "$40",
                 "PHP and MySQL Web Development (Developer's Library) by Luke Welling" => "$50",
                 "PHP Object-Oriented Solutions (Paperback) by David Powers" => "$35");

    $result = "";

    if (isset($_POST['sub_search'])){
        $text = $_POST['book_name'];

        if (array_key_exists($text, $book_arr))
            $result = "Book Name : ".$text."<br />"."Book Price : ".$book_arr[$text];
        else
            $result = "Book Not Found";
    }

    if (isset($_POST['sub_update'])){
        $text = $_POST['book_name'];
        $price = $_POST['price'];

        if (array_key_exists($text, $book_arr)){
            $book_arr[$text] = $price;
            $result = "Book Price Updated Successfully";
        } else
            $result = "Book Not Found";
    }

    if (isset($_POST['sub_delete'])){
        $text = $_POST['book_name'];

        if (array_key_exists($text, $book_arr)){
            unset($book_arr[$text]);
            $result = "Book Deleted Successfully";
        } else
            $result = "Book Not Found";
    }
?>