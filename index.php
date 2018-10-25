<?php
require_once('view/header.php');
?>
        Création d'un compte, Débiter le compte, Créditer le compte
        <div>

            <form action="cible.php" method="post">
            <p>
                <input type="text" name="numCompte" placeholder="Numéro de compte"/>
                <input type="number" name="soldeCompte" placeholder="Solde du compte"/>
                <input type="text" name="monnaie" placeholder="Monnaie d'origine"/>

                <input type="submit" value="Valider" />
                <input type="submit" value="Débiter le compte" />
                <input type="submit" value="Créditer le compte" />
            </p>
            </form>
        </div>
    </body>
</html>