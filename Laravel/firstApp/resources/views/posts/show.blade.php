@extends('layouts.app')

@section('content')
    <a href="/firstApp/public/posts/" class="btn btn-outline-secondary">Go Back</a>
    <br><br>
    <h1>{{$post->title}}</h1>
    <div>{!!$post->body!!}</div>
    <hr>
    <small>Written on {{$post->created_at}}</small>
    <hr>
    <a href="{{$post->id}}/edit" class="btn btn-info">Edit</a>

    {!!Form::open(['action' => ['PostsController@destroy', $post->id], 'method' => 'POST', 'class' => 'float-right'])!!}
        {{Form::hidden('_method', 'DELETE')}}
        {{Form::submit('Delete', ['class' => 'btn btn-danger'])}}
    {!!Form::close()!!}
@endsection
