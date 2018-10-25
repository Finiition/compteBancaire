<?php

require_once('view/header.php');

?>

<h1>Page de création</h1>

<form action="cible.php" method="post">
    <p>
        <input type="text" name="numCompte" placeholder="Numéro de compte"/>
        <input type="text" name="monnaie" placeholder="Monnaie d'origine"/>

        <input type="submit" value="Valider" />
    </p>
</form>