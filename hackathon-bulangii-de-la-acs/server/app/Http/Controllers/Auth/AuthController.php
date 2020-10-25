<?php

namespace App\Http\Controllers\Auth;

use App\Client;
use App\Consult;
use App\PdfS;
use App\Recipe;
use App\Schedule;
use App\User;
use Carbon\Carbon;
use Illuminate\Http\Request;
use App\Http\Controllers\Controller;
use Illuminate\Support\Facades\Auth;

class AuthController extends Controller
{
    public function login(Request $request)
    {
        $request->validate([
            'email' => 'required|string|email',
            'password' => 'required|string',
            //'remember_me' => 'boolean'
        ]);
        $credentials = request(['email', 'password']);
        // dd($credentials);
        if (!Auth::attempt($credentials))
            return response()->json([
                'message' => 'Unauthorized'
            ], 401);
        $user = $request->user();
        $tokenResult = $user->createToken('Personal Access Token');
        $token = $tokenResult->token;
        if ($request->remember_me)
            $token->expires_at = Carbon::now()->addWeeks(1);
        $token->save();
        return response()->json([
            'access_token' => $tokenResult->accessToken,
            'token_type' => 'Bearer',
            'expires_at' => Carbon::parse(
                $tokenResult->token->expires_at
            )->toDateTimeString()
        ]);
    }

    public function register(Request $request)
    {

        // dd($request->fName);
        $request->validate([
            'fName' => 'required|string',
            'lName' => 'required|string',
            'email' => 'required|string|email|unique:users',
            'spassword' => 'required|string'
        ]);
        $user = new User;
        $user->first_name = $request->fName;
        $user->last_name = $request->lName;
        $user->email = $request->email;
        $user->name = $request->name;
        $user->password = \Hash::make($request->spassword);
        $user->typeuser = 1;
        $user->save();

        return response()->json([
            'message' => 'Successfully created user!'
        ], 201);
    }

    public function logout(Request $request)
    {
        $request->user()->token()->revoke();
        return response()->json([
            'message' => 'Successfully logged out'
        ]);
    }

    /**
     * Get the authenticated User
     *
     * @return [json] user object
     */
    public function user(Request $request)
    {
        return response()->json($request->user());
    }

    public function getAllClients(Request $request)
    {
        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }
        $clients = Client::get();
        return response()->json($clients);
    }

    public function getClient(Request $request)
    {
        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }
        $cnp = $request->cnp;
        $client = Client::where('cnp', '=', $cnp)->first();
        if ($client) {
            return response()->json($client);
        } else {
            return response()->json([
                'message' => 'Pacientul nu exista'
            ], 401);
        }

    }

    public function addClient(Request $request)
    {
        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }
        $request->validate([
            'fName' => 'required|string',
            'lName' => 'required|string',
            'email' => 'required|string|email|unique:users',
            'spassword' => 'required|string',
            'name' => 'required|string',
            'sex' => 'required',
            'judet' => 'required|string',
            'oras' => 'required|string',
            'adresa' => 'required|string',
            'cod_asigurat' => 'required|string',
            'numar_document' => 'required|string',
            'cnp' => 'required|string',
            'data_nasterii' => 'required|string'
        ]);
        $user = new User;
        $user->first_name = $request->fName;
        $user->last_name = $request->lName;
        $user->email = $request->email;
        $user->name = $request->name;
        $user->password = \Hash::make($request->spassword);
        $user->typeuser = 2;
        $user->save();

        $client = new Client;
        $client->user_id = $user->id;
        $client->fname = $request->fName;
        $client->lname = $request->lName;
        $client->sex = $request->sex;
        $client->judet = $request->judet;
        $client->oras = $request->oras;
        $client->adresa = $request->adresa;
        $client->cod_asigurat = $request->cod_asigurat;
        $client->numar_document = $request->numar_document;
        $client->cnp = $request->cnp;
        $client->data_nasterii = $request->data_nasterii;

        $client->save();
        return response()->json([
            'message' => 'Successfully created client!'
        ], 201);
    }
    public function clientGetInfos(Request $request)
    {
        if ($request->user()->typeuser == 1) {
            return response()->json([
                'message' => 'Doctorul nu poate accesa aceasta ruta'
            ], 403);
        }
        $client = Client::where('user_id', '=', $request->user()->id)->first();
        return response()->json($client);

    }
    public function getApp(Request $request)
    {
        if ($request->user()->typeuser == 1) {  //doc
            $apps = Schedule::where('doc_id','=', $request->user()->id)->get();
            forEach($apps as $app) {
                $client = User::where('id', '=', $app->client_id)->first();
                $app->setAttribute('fname', $client->first_name);
                $app->setAttribute('lname', $client->last_name);
            }

            return response()->json($apps);}
        if ($request->user()->typeuser == 2) {  //pacient
            $apps = Schedule::where('client_id','=', $request->user()->id)->get();
            $appfull = [];
            forEach($apps as $app) {
                $client = User::where('id', '=', $app->doc_id)->first();
                $app->setAttribute('fname', $client->first_name);
                $app->setAttribute('lname', $client->last_name);
            }

            return response()->json($apps);
        }
    }
    public function addApp(Request $request) {
        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }
        $request->validate([
            'appointment' => 'required',
            'specializare' => 'required|string',
            'cnp' => 'required|string'
        ]);
        $appointment = new Schedule();
        $appointment->appointment = $request->appointment;
        $appointment->specializare = $request->specializare;
        $appointment->doc_id = $request->user()->id;
        $appointment->client_id = Client::where('cnp', '=', $request->cnp)->first()->user_id;
        $appointment->save();
        return response()->json([
            'message' => 'Successfully created appointment!'
        ], 201);
    }
    public function getCons(Request $request)
    {
        $client = Client::where('cnp', '=', $request->cnp)->first();
        if (!$client) {
            return response()->json(["message" => "Client not found"], 404);
        }
//        dd($client);
        $cons = Consult::where('client_id', '=', $client->id)->get();

        return response()->json($cons);

    }
    public function getRecip(Request $request)
    {
        $client = Client::where('cnp', '=', $request->cnp)->first();
        if (!$client) {
            return response()->json(["message" => "Client not found"], 404);
        }
        $recip = Recipe::where('client_id', '=', $client->id)->first();
        if(!$recip) {
            $recip = new Recipe();
            $recip->client_id = $client->id;
            $recip->infos = "";
            $recip->save();
        }
        return response()->json($recip);

    }
    public function addCons(Request $request)
    {
        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }
        $client = Client::where('cnp', '=', $request->cnp)->first();
        if (!$client) {
            return response()->json(["message" => "Client not found"], 404);
        }
        $cons = new Consult();
        $cons->infos = $request->infos;
        $cons->doc_name = $request->doc_name;
        $cons->when = $request->when;
        $cons->client_id = $client->id;
        $cons->save();
        return response()->json(['message'=> 'A mers pula mea']);
    }
    public function addRecip(Request $request)
    {
        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }
        $client = Client::where('cnp', '=', $request->cnp)->first();
        if (!$client) {
            return response()->json(["message" => "Client not found"], 404);
        }
        $recip = Consult::where('client_id', '=', $client->id)->first();
        $recip->infos = $request->infos;
        $recip->save();
        return response()->json($recip);
    }
    public function getPDF(Request $request)
    {
        $client = Client::where('cnp', '=', $request->cnp)->first();
        if (!$client) {
            return response()->json(["message" => "Client not found"], 404);
        }
        $pdf = PdfS::where('client_id', '=', $client->user_id)->get();
        if(count($pdf) == 0) {
            return response()->json(["message" => "Pacientul nu are pdfuri"], 404);
        }
        return response()->json($pdf);
    }
    public function addPDF(Request $request) {

        if ($request->user()->typeuser == 2) {
            return response()->json([
                'message' => 'Pacientul nu poate accesa aceasta ruta'
            ], 403);
        }

        $request->validate([
            'pdf' => 'required',
            'pdf.*' => 'mimes:pdf|max:200048'
        ]);
//        dd("clock");

        $name=rand(1234,9999).$request->file('pdf')->getClientOriginalName();
        $request->file('pdf')->move(public_path().'/pdf/', $name);
        $data = '/pdf/'.$name;
        $pdf = new PdfS();
        $pdf->title = $request->title;
        $pdf->path = $data;
        $pdf->client_id = Client::where('cnp', '=', $request->cnp)->first()->user_id;
        $pdf->save();
        return response()->json([
            'message' => 'Successfully added pdf!'
        ], 201);
    }

}
