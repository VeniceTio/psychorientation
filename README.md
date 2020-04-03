# Psychorientation

- Rédacteurs : Antoine FÉLIX, Loïc GROSS, Yoann LOUAZEL, Antoine TRITSCHBERGER et Grégory ADAM.
- [URL GIT](https://git.unistra.fr/m.a.t.h.s.-manieurs-de-l-avenir-technologique-des-humains-stup-faits/psychorientation)

![Illustration](/images/fenetrePrincipale.PNG)

## Procédure d'installation

[Cliquez ici pour télécharger le jeu](https://git.unistra.fr/m.a.t.h.s.-manieurs-de-l-avenir-technologique-des-humains-stup-faits/psychorientation/-/raw/master/historique_prototypes/Psychorientation_V8.exe?inline=false)<br/>
Une fois téléchargé, le jeu est prêt à être démarré.

## Cahier Des Charges

[Lien vers le CDC](./CDC.md)

## Description du jeu
- __Type de jeu :__ Gestion 
- __Incarnation du joueur :__ Un professeur principal d’une classe de lycée

Ce jeu est un jeu sérieux qui va vous permettre de gérer une classe avec différents profils d'élèves pour vous faire découvrir le rôle d'enseignant et les décisions qui lui incombe comme le choix de notation et le niveau de la difficulté de ces cours.

## Déroulement d’une partie

![Illustration](/images/choixScenario.PNG)

La partie commence par le choix du scénario, vous avez le choix entre une classe prédéfinie et une classe aléatoire. Une fois le scénario choisi vous allez pouvoir choisir les coefficient de notation et le niveau des cours (panneau de droite). ensuite vous pourrez passer au tour suivant en cliquant sur la flèche verte en bas à droite. Une fois tous les mois passé vous aurez un indicatif sur tous les élèves et le choix de recommencer ou vous arrêtez là.

### Paramétrage d’une partie

Aucun paramétrage de partie n’est nécessaire
__Modèle conceptuel applicatif__

### Description des fonctionnalités 
__Entrée__
##### Gestion des tours

- _Valider_ : Valide les choix du tour et passer au tour suivant

##### Gestion des choix
![Illustration](/images/choixTour.PNG)
- _Notation effort_ : coefficient que prend les efforts dans la notation
- _Notation compétence_ : coefficient que prend les compétences dans la notation
- _Niveau des cours_ : le niveau de compétence requis pour le cours

__Sorties__

![Illustration](/images/infoSorti.PNG)

__Gestion des tours__
- _moisActuel_ : le mois actuel du tour
- _anneeActuelle_ : la classe actuelle du tour

__Gestion de la classe__
- _MoyenneClasse_ : la moyenne générale de la classe
- _CompetenceClasse_ : la moyenne des compétences actuelles de la classe
- _EffortClasse_ : la moyenne des efforts actuels de la classe

__Gestion des élèves__

- _idEleve_ : le numéro de l’élève
- _EffortEleve_ : l’effort actuel de l’élève
- _CompetenceEleve_ : la compétence actuel de l’élève
- _DerniereNoteEleve_ : la dernière note reçu par l’élève
- _ClasseEleve_ : la classe actuelle de l’élève
- _MoyenneEleve_ : la moyenne générale actuelle de l’élève
- _listeNotesEleve_ : toutes les notes de l’élèves avec ces compétence et effort au moment de la note

### Scénarios complémentaires

Partie libre avec une classe entre 6 et 8 élèves, avec des attributs aléatoires, pour comprendre la complexité de différentes composition de classe.

![Illustration](/images/scenarioComplementaire.PNG)![Illustration](/images/scenarioComplementaire2.PNG)

8 élèves : [ <Élève n, effort aléatoire, compétence aléatoire, dernière note en fonction de l’effort (coeff 1) et de la compétence (coeff 1)>  ]
nombre de tours : 28

