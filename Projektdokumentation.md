# Projekt-Dokumentation
Agachan Atputharasa

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  18.08.23     | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|  25.08.23     | ...     |                                                              |
|  01.09.23     | 1.0.0   |                                                              |

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

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
