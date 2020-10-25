<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Client extends Model
{
    protected $fillable = [
        'fname', 'lname', 'sex', 'judet', 'oras', 'adresa', 'cod_asigurat', 'numar_document', 'cnp', 'data_nasterii',
    ];


    public function user()
    {
        return $this->belongsTo(User::class);
    }
}
