# Projekt-Dokumentation
Agachan Atputharasa

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  18.08.23     | 0.0.1   | Ich machte mir Gedanken, wie ich dieses Projekt Objektorientiert programmieren kann. |
|  25.08.23     | 0.0.2     | Ich konnte wie im Plan steht diese Arbeitspakete lösen                                                             |
|  01.09.23     | 0.1.0   |   Es gab Probleme  die ich noch geschafft habe zu lösen                                                         |
|  08.09.23     | 1.0.0   |   Programm fertig geschrieben                                                           |
## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt modifiziere ich meinen alten Projekt Random Number Guesser Objektorientiert Programmiere und ich ein Zweispielermodus und eine Highscoreliste ergänze.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss | Funktional| Als ein Programmierer möchte ich eine Zufallszahl generieren, damit der Benutzer, dass spielen kann. |
| 2    | Muss | Funktional| Als ein Benutzer möchte ich das Zahl raten können, damit ich es überhaupt spielen kann.|
| 3    | Muss | Funktional| Als ein Benutzer möchte ich ein Hinweis bekommen, damit ich weiss, ob die geratene Zahl grösser oder niedriger ist als die geratene Zahl oder es erraten wurde.|
| 4    | Muss | Funktional| Als ein Programmierer möchte ich die Anzahl der Rateversuche ausgeben, damit der Benutzer sich konstant verbessern kann.|
| 5    | Muss | Funktional|  Als ein Benutzer möchte ich den Zahlenbereich selber aussuchen können, damit der Benutzer den Schwierigkeitsgrad selber entscheiden kann.|
| 6    | Muss | Funktional| Als ein Programmierer möchte ich ein Zweispielermodus erstellen, damit der Benutzer mit Freunden spielen kann.|
| 7    | Muss | Funktional| Als ein Benutzer möchte ich, dass ich mehrere Runden das Spiel spielen kann, damit der Benutzer nicht immer wieder das Programm schliessen muss.|
| 8    | Muss | Funktional| Als ein Programmierer möchte ich ein Highscoreliste generieren, damit der Benutzer sich mit seinen Freunden vergleichen kann.|
| 9  | Muss | Rand | Das Programm soll in C# geschrieben sein.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet, Singleplayer Modus gewählt, Zahlenbereich ausgewählt             |   -      | Zufallszahl generiert,Guess the number between 1 and  1000 |
| 2.1  | Programm gestartet, Singleplayer Modus gewählt, Zahlenbereich ausgewählt,  Zufallszahl generiert,Guess the number between 1 and 1000           |   500      |  500     |
| 3.1  | Programm gestartet, Singleplayer Modus gewählt, Zahlenbereich ausgewählt,  Zufallszahl generiert,Guess the number between 1 and 1000           | 350        |  Your guess is higher than the actual number. Try Again!    |
| 4.1  | Programm gestartet, Singleplayer Modus gewählt, Zahlenbereich ausgewählt,  Zufallszahl generiert,Guess the number between 1 and 1000        | 250        |  Congratulations! You have guessed the correct number in 3 guesses.  |
| 5.1  | Programm gestartet, Singleplayer Modus gewählt, Choose the range of numbers you would like to guess             |  1000       |  Guess the number between 1 and 1000                 |
| 6.1  | Programm gestartet,Select game mode:, 1. Single Player, 2. Two Player             |   2      | Choose the range of numbers you would like to guess!, Choose the number you would like the other player to guess                  |
| 7.1  | Programm gestartet, Singleplayer Modus gewählt, Zahlenbereich ausgewählt,  Zufallszahl generiert, Zufallszahl erraten             |     -    | Select game mode:, 1. Single Player, 2. Two Player                  |
| 8.1  |  Programm gestartet, Singleplayer Modus gewählt, Zahlenbereich ausgewählt,  Zufallszahl generiert, Zufallszahl erraten             |    -     |   Congratulations! You have guessed the correct number in 1 guesses. High Scores:1|


### 1.4 Diagramme
![Number Guessing Game](https://github.com/AAgachan/LA-1300/assets/110893260/c01b0f1e-3880-4e74-9b13-11c2447c8c3f)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 18.08.23      |    A.Atputharasa         |   eine Zufallszahl generieren            |     5'          |
| 2.A  | 25.08.23      |  A.Atputharasa           | das Zahl raten können             | 5'              |
| 3.A  |25.08.23       |    A.Atputharasa         |  ein Hinweis bekommen             | 20'              |
| 4.A  | 25.08.23      |     A.Atputharasa        |die Anzahl der Rateversuche ausgeben              |   30'            |
| 5.A  |  25.08.23     |  A.Atputharasa           | Zahlenbereich selber aussuchen können              | 30'              |
| 6.A  | 1.09.23      |     A.Atputharasa        |   ein Zweispielermodus erstellen            | 90'              |
| 7.A  |1.09.23       |      A.Atputharasa       |  mehrere Runden das Spiel spielen            | 30'              |
| 8.A  | 1.09.23      |           A.Atputharasa  |   ein Highscoreliste generieren            |    45'           |
Total: 255'


## 3 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 18.08.23       |   A.Atputharasa          |  5'            |    5'           |
| 2.A  |25.08.23        |    A.Atputharasa         |    5'          |      5'         |
| 3.A  | 25.08.23       |        A.Atputharasa     |      20'        |      15'         |
| 4.A  | 25.08.23       |           A.Atputharasa  |       30'       |        45'       |
| 5.A  |   25.08.23     |         A.Atputharasa    |        30'      |      15'         |
| 6.A  | 1.09.23      |         A.Atputharasa    |          90'    |         120'      |
| 7.A  |  1.09.23     |        A.Atputharasa     |           30'   |       10'        |
| 8.A  |  1.09.23     |         A.Atputharasa    |            45'  |       20'        |


## 4 Kontrollieren

### 4.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   1.09.23     | OK         | A.Atputharasa       |
| 2.1  |     1.09.23   |   OK       |  A.Atputharasa        |
| 3.1  |     1.09.23   |   OK       |  A.Atputharasa        |
| 4.1  |     1.09.23   |     OK     |   A.Atputharasa       |
| 5.1  |       1.09.23 |       OK   |    A.Atputharasa      |
| 6.1  |    1.09.23    |         OK |     A.Atputharasa     |
| 7.1  |       1.09.23 |          OK|      A.Atputharasa    |
| 8.1  |       1.09.23 |          OK|        A.Atputharasa  |

Es gab hier keine Probleme.

