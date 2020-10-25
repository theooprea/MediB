<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateClientsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('clients', function (Blueprint $table) {
            $table->id();
            $table->timestamps();
            $table->string('user_id')->references('id')->on('users');
            $table->string('fname');
            $table->string('lname');
            $table->integer('sex');
            $table->string('judet');
            $table->string('oras');
            $table->string('adresa');
            $table->string('cod_asigurat');
            $table->string('numar_document');
            $table->string('cnp');
            $table->string('data_nasterii');


        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('clients');
    }
}
