# Projekt-Dokumentation



Deer Broder, Dakaj, Yildirim, Tosuni

| Datum | Version | Zusammenfassung                                              |
| 27.10.2022| 001| Wir haben uns zuerst informiert, über das Thema. Dann haben wir die User Stories erstellt, die Testfälle erstellt, das Diagramm erstellt und geplant.|
|       |    |  |
|       |     |                                                              |
|       |   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein Programm, wo man Wörter auf English lernen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | funktional                |muss      | Als User möchte ich, dass ein englisches Wort angezeigt wird, damit ich das deutsche Wort aufschreiben muss. |
| 2  | funktional                |muss      | Als User möchte ich, dass richtig oder falsch ausgegeben wird, damit ich weiss ob ich das Wort richtig oder falsch geschrieben habe.                                   |
| 3 | funktional                |muss      | Als User möchte ich, dass das richtige Wort ausgegeben wird, damit ich das Wort solange eingeben kann bis es richtig ist.                                   |
| 4 | funktional              |muss      | Als User möchte ich, dass wenn das Wort beim ersten Versuch richtig erratten wurde, immer +1 Punkt ausgegeben wird, damit am Schluss alle Punkte zusammengerechnet werden können.                                   |
| 5 | funktional  |muss      | Als User möchte ich, dass wenn ein Wort richtig eingegeben wurde das nächste Wort ausgegeben wird, damit man das nächste Wort wieder eingeben kann.                      |
| 6 | qualität  |kann      |Als User möchte ich, dass wenn das Wort richtig eingegeben wurde, das Wort grün angezeigt wird und bei falscher Eingabe rot, damit mir die richtigen und falschen Wörter besser ins Auge stechen.               |
| 7 | funktional  |muss      | Als User möchte ich, dass wenn ich fertig bin das Programm mich fragt, ob ich das Programm neustarten möchte, damit ich wieder lernen kann.                    |
| 8 | funktional  |muss      | Als User möchte ich, dass das Programm mit Fehleingaben umgehen kann, damit ich keine Zahl oder andere Eingaben eingeben kann.          |


  




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.2  | Wörter werden abgefragt             |Deutsche Wörter         |richtig oder falsch                   |
| 2.2  | Das Wort ist falsch            |erneute Nachfrage         |richtiges Wort                    |
| 3.2  | Das Wort ist richtig            |das es richtig ist        |+1 Punkt
| 4.2  | Das Wort ist richtig und +1 Punkt wurde angezeigt| keine Eingabe| das nächste Wort erscheint| 
| 5.2  | wollen sie weiter spielen?| ja oder nein| wenn ja programm erneut abspielen wenn nein programm schliessen|
| 6.2  | geben sie das deutsche wort ein |4| schreiben sie das deutsche wort ein|
| 7.2  | wenn fertig|-| anzahl Punkte|







### 1.4 Diagramme

[![image](https://user-images.githubusercontent.com/111045987/198239401-fb5a916e-fe66-418c-9a79-32fe8a83a5a5.png)
]

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |  03.11.2022      |           | US 1             | 2 *  45 min             |
| 2.A  | 10.11.2022      |           | US 2             | 2 * 45 min               |
| 3.A  | 10.11.2022      |           | US 3             | 2 * 45 min               |
| 4.A  | 10.11.2022      |           | US 4           | 2 * 45 min               |
| 5.A  | 17.11.2022      |           | US 5           | 45 min               |
| 6.A  | 17.11.2022      |           | US 6           | 45 min               |
| 7.A  | 17.11.2022      |           | US 7           | 2 * 45 min               |
| 8.A  | 17.11.2022      |           | US 8           | 2 * 45 min               |
Total: 630 min


## 3 Entscheiden

Wir haben uns entschieden mit C# ein Programm zu programmieren, mit dem wir Wörter lernen können.

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
