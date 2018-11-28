@extends('layouts.app')

@section('content')
    <div class="jumbotron text-center">
        <h1>Welcome to my first Laravel Site</h1><br>
        <h3>This is the Index Page</h3>
        <a href="/login" class="btn btn-primary btn-lg" role="button">Login</a>
        <a href="/register" class="btn btn-success btn-lg" role="button">Register</a>
    </div>
@endsection
