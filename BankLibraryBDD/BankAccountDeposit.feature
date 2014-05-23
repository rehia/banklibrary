Feature: Depot sur un compte bancaire
	Afin d'augmenter le solde de mon compte
	En tant que client
	Je veux déposer de l'argent dessus


Scenario: Réaliser 1 seul dépôt
	Given J'ai un compte de numéro 012345
	And Le solde de mon compte est de 0 dollar
	When Je dépose 1 dollar
	Then Le solde de mon compte est de 1 dollar

Scenario: Réaliser 2 dépôts consécutifs
	Given J'ai un compte de numéro 012345
	And Le solde de mon compte est de 0 dollars
	When Je dépos 1 dollar
	And Je dépose 5 dollars
	Then Le solde de mon compte est de 6 dollars
