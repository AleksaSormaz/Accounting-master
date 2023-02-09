<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index2.aspx.cs" Inherits="Accounting_services.index3" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
    <link rel="stylesheet" href="/css/index.css">
    <link rel="icon" href="/Slike/ikona.jpg" type="image/icon">
    <script src="/JS/jquery-3.6.0.js"></script>
    <title>Prijava</title>
    <style>
        legend {
            color: orange;
        }
    </style>
</head>

<body>
    <form action="get" method="get" class="form-control-md" style="width:70%;margin:auto;" id="formular" onsubmit=""
        novalidate>
        <fieldset class="form-group">
            <legend>Lični podaci</legend>

            <label for="ime">Vaše ime:</label>
            <input type="text" name="ime" id="name" class="form-control" required>

            <label for="prezime">Vaše prezime:</label>
            <input type="text" name="prezime" id="surname" class="form-control" required>

            <label for="telefon">Mobilni telefon:</label>
            <input type="tel" name="telefon" class="form-control" id="tel" required>

            <label for="mail">Vaša e-mail adresa:</label>
            <input type="email" name="mail" id="mail" class="form-control" required>

            <label for="naziv_firme">Naziv firme:</label>
            <input type="text" name="naziv_firme" id="company_name" class="form-control" required>

            <label for="pib">PIB firme:</label>
            <input type="text" name="pib" class="form-control" id="pib" required>
        </fieldset>

        <input type="submit" name="submit" value="Pošalji" />
        <input type="reset" name="reset" value="Obriši" />
    </form>
    <script src="/JS/provere.js"></script>
</body>

</html>
