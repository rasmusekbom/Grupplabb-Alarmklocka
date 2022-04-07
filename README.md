# Uppgiftsbeskrivning

## Scenario 

I denna laboration ska en digital klocka med alarmfunktion skapas. Klockan ska visas i ett grafiskt gränssnitt (GUI) med timmar och minuter

## Kriterier för Godkänt

### Del 1
Skapa en digital klocka som visar tid.

· Klockan ska kunna startas och stoppas med en knapp.

· Den initiala tiden för klockan ska kunna sättas med timmar och minuter. Tiden som sätts ska verifieras att det är en giltig tid. Man ska m.a.o. inte kunna sätta tider som exempelvis 24:67 eller något annat orimligt.

· Klockan ska inte gå att starta om en felaktig tid matats in.

· Klockan startar alltid med den angivna tiden, även efter en stop/start.

· När klockan är startad, går det ej att ändra tid. Textrutorna ska inaktiveras.

· Klockan går fort. En verklig sekund motsvarar en minut för denna klocka.

### Del 2
Skapa en alarmfunktion till klockan.

· Ett alarm ska kunna aktiveras och deaktiveras

· Alarm anges i timmar och minuter

· Alarmtiden som sätts ska verifieras att det är en giltig tid. Man ska m.a.o. inte kunna sätta tider som exempelvis 10:63 eller något annat orimligt.

· Alarmet ska inte kunna aktiveras om en felaktig alarmtid matats in.

· Indikation av aktivt larm får göras på godtyckligt sätt – Ljud, bild, blinkande/skiftande bakgrund, night rider med radio buttons, etc

· Aktivt larm ska indikeras i 10 min, d.v.s. ett alarm som exempelvis startar 10:55 ska indikera tills 11:05

· När alarmet är aktiverat går ska det inte gå att ändra alarmtiden, textrutorna ska inaktiveras

### Del 3

Dessa klasser måste finnas i lösningen:
**Clock** Klassen Clock håller koll på Hour och Minute. Klockans funktion:

· Varje sekund tickas minuter upp med 1.

· Om minuter blir > 59 återställs de till 0 och timmar tickas upp med 1.

**Hour** Klassen Hour håller koll på timmar

**Minute** Klassen Minute håller koll på minuter

**Alarm** Klassen Alarm håller reda på en alarmtid samt kontrollerar om ett alarm ska vara aktivt eller ej.

## Utförande
Sätt ihop en lösning bestående av klocka och alarm (del1 och del2). Det är frivilligt att använda interface till klasserna. Ett krav i denna laboration är att programmet inte ska krascha. Detta betyder alltså att ni måste testa programmet ordentligt innan inlämning. I laborationen ska användaren kunna sätta två individuella larm, samt tydligt kunna se vilket alarm som eventuellt indikeras/larmar.
