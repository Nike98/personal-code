<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class PagesController extends Controller
{
    // Demo index method
    public function index(){
        return view('pages.index');
    }

    // Demo about method
    public function about(){
        return view('pages.about');
    }

    // Demo services method
    public function services(){
        // Making a sample Associative Array
        $data = array(
            'food' => ['Pizza', 'Pasta', 'Lasagne']
        );
        return view('pages.services')->with($data);
    }
}
