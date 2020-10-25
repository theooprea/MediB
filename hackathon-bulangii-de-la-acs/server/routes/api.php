<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::group([
    'prefix' => 'auth'
], function () {
    Route::post('login', 'Auth\AuthController@login')->name('login');
    Route::post('register', 'Auth\AuthController@register');
    Route::group([
      'middleware' => 'auth:api'
    ], function() {
        Route::get('logout', 'Auth\AuthController@logout');
        Route::get('user', 'Auth\AuthController@user');
        Route::get('client/{cnp}', 'Auth\AuthController@getClient');
        Route::post('client', 'Auth\AuthController@addClient');
        Route::get('clients', 'Auth\AuthController@getAllClients');
        Route::get('getInfos', 'Auth\AuthController@clientGetInfos');
        Route::get('getApp', 'Auth\AuthController@getApp');
        Route::post('getApp', 'Auth\AuthController@addApp');
        Route::get('getCons/{cnp}', 'Auth\AuthController@getCons');
        Route::get('getRecip/{cnp}', 'Auth\AuthController@getRecip');
        Route::post('getCons/{cnp}', 'Auth\AuthController@addCons');
        Route::post('getRecip/{cnp}', 'Auth\AuthController@addRecip');
        Route::get('getPDF/{cnp}', 'Auth\AuthController@getPDF');
        Route::post('getPDF/{cnp}', 'Auth\AuthController@addPDF');


    });
});
