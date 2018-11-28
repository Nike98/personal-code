@extends('layouts.app')

@section('content')
    <h1>Welcome to my first Laravel Site</h1><br><br>
    @if (count($food) > 0)
        <ul class="list-group">
            @foreach ($food as $item)
                <li class="list-group-item">{{$item}}</li>
            @endforeach
        </ul>
    @endif
@endsection
