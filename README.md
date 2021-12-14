# Unity

Projekt to gra z gatunku horror w 3d.

Gra zawiera jumpscare'y.

Link do pobrania gry: https://drive.google.com/file/d/1kIySDm0oP0LX8wwg0RQ8zSbuGbg5c0vE/view?fbclid=IwAR3dEhi91sKt-qReufxy9WKsg_erPcwOCHNRbAJixJ-2Se-c9x6j12XDIqQ

Link do filmiku z gry:

Gra polega na znalezieniu 3 kluczy i ucieczki ze szpitala.

Informacje o duchu

Duch zaczyna gonić gracza po podniesieniu pierwszego klucza i z każdym kolejnym, który zbierzemy jego krzyk zmienia się na bardziej przerażający i duch zaczyna lecieć w naszą stronę szybciej. Płacz ducha staje się coraz głośniejszy im bliżej jesteśmy ducha.

![ghostImage0](https://user-images.githubusercontent.com/46341836/146008631-e2fe7b8c-e61f-4047-9a88-411af6f0456f.PNG)

![GhostImage1](https://user-images.githubusercontent.com/46341836/146009908-f58dc1b6-cd9f-4fd9-a826-a9b750ac704b.PNG)


Obiekty ducha zawiera w sobie dwa AudioSource + Collider, który wykrywa gdy gracz w niego wejdzie.

![GhostCollision](https://user-images.githubusercontent.com/46341836/146008836-cd05ce54-ec96-4061-9d0d-6a886ca5ae1d.PNG)


OnTriggerEnter sprawdza czy gracz wszedł (albo duch wszedł w zasięg collidera po czym:
- bierze pierwszy i drugi AudioSource (grający ciągle, czyli płacz i krzyki przy podniesieniu klucza) i je wycisza.
- Po czym włącza filmik (jumpscare) osadzonym na elemencie Canvasu.
- odtwarza filmik, z obiektu ghostEaten i go odtwarza.
- Potem wyzwala funkcję Coroutine aby zrobić 1 sekundowe opóźnienie (dzięki czemu filmik się odtwarza, a po tym następuje przejście do sceny końcowej).

Polowanie na gracza zaczyna się po zebraniu pierwszego klucza.

![GhostHunt](https://user-images.githubusercontent.com/46341836/146010188-70b008ba-4231-431c-b47e-bed77d0b8b01.PNG)

LookAt sprawia, ze obiekt jest skierowany frontalnie do gracza na osi Z, po czym następuje Translate, gdzie porusza się po osi Z.

Duch zaczyna krzyczeć gry gracz podnosi klucze.

![GhostScreamOnKeyPickup](https://user-images.githubusercontent.com/46341836/146010644-609f4fc7-4102-4cda-9169-ab505f21c766.PNG)

Tutaj sprawdzamy kolejno ile gracz podniósł kluczy.
Aby zapobiec zapętleniu odtwarzanego dźwieku dodałem zmienne boolowskie startScream.
Sprawdzane jest ile gracz posiada kluczy, jeśli zbierze 1, 2 lub 3 klucze jednorazowo jest odtwarzany dźwięk.
Zmieniana jest wysokość odtwarzanego dźwięku na niższy z każdym zebranym kluczem, a w przypadku zebrania trzeciego, dodawany jest bypassEffect.

Informacje o kluczach

![Key](https://user-images.githubusercontent.com/46341836/146011426-86745028-89aa-4cf1-aedc-983596d187af.PNG)

Klucz zawira Collider.

![KeyPickup](https://user-images.githubusercontent.com/46341836/146011466-6bd2cc44-cb3e-406b-8ca8-58a2b95b47c9.PNG)

Skrypt w metodzie update sprawdza ile gracz posiada kluczy, aby aktualizować obiekt tekst na ekranie.

Funkcja OnTriggerEnter sprawdza czy collider gracz wszedł na collider klucza.

Jeśli tak to:
- zwiększ liczbę kluczy o 1.
- Wznów dźwięk podnoszenia klucza.
- Ustawia zmienną startHunting odpowiedzialną za polowanie ducha na true.
- a potem ustaw szybkość ducha w zależności od liczby podniesionych kluczy.
- na końcu odpala dźwięk podniesionego klucza i niszczy obiekt klucza wraz z colliderem.

Informacje o clipboard

Gra zawiera obiekt clipboard wraz z jego colliderem oraz canvas, który po podniesieiu clipboard'a się odpala.

![Clipboard](https://user-images.githubusercontent.com/46341836/146012919-59e673c0-9d09-426b-9b60-d0124e93ce5e.PNG)
![Canvas](https://user-images.githubusercontent.com/46341836/146013068-2bf27436-c66e-44a5-ae12-0a2492f95549.PNG)
![panel](https://user-images.githubusercontent.com/46341836/146013077-6adb1534-7136-4ac4-8c02-103fd67dbe1e.PNG)


![ClipBoardPickup](https://user-images.githubusercontent.com/46341836/146013248-a241dbe4-00e2-447d-ab67-b2c63329487e.PNG)

Po najściu na collider clipboard'a zostaje on zniszczony.

![TriggerClipBoardAppear](https://user-images.githubusercontent.com/46341836/146013308-a5b62133-4876-40e7-be0a-d9564e4582fc.PNG)

Następuje zatrzymanie gry oraz zostaje włączony canvas z obiektem panel oraz tekst, który zostanie wyświetlony na ekranie.


![GameState](https://user-images.githubusercontent.com/46341836/146013864-a6e7f0fa-47cf-4217-804b-3ec8c1140ef3.PNG)
![DisableClipboard](https://user-images.githubusercontent.com/46341836/146013875-6c067297-cd74-4248-bd1d-b2e74aa34063.PNG)

Gdy gracz wciśnie spacje gra zostanie wznowiona, a canvas zostanie wyłączony.

Informacje o lalce

W grze znajduje się lalka, która po podniesieiu klucza natychmiastowo zmienia swoje rozmiary i położenie.

![kid](https://user-images.githubusercontent.com/46341836/146015501-4432c34d-10d8-4992-b358-404e89206a67.PNG)


![TriggerKid](https://user-images.githubusercontent.com/46341836/146015521-5e7f1df8-a7f1-4a4f-9f4a-12bea34871c0.PNG)

Po wejściu na collider lalki, następuje zmiana localScale oraz zmiena położenia, aby lalka nie zapadała się pod ziemie.
Collider zostaje zniszczony.

Informacje o światłach

Z każdym zebranym kluczem, w szpitalu będą gasły światła.

![TurnOffLights0](https://user-images.githubusercontent.com/46341836/146015972-16b79db0-bdb5-4f38-b619-0c692224ac15.PNG)
![TurnOffLights1](https://user-images.githubusercontent.com/46341836/146015991-38d9a73a-0484-4d16-a10a-7cd6b528903f.PNG)

Oczywiście kod do zoptymalizowania.

- Znajdujemy dany GameObject po jego nazwie i przypisujemy do zmiennej.
- Potem w zależności od posiadanych kluczy, dostajemy się do komponentu light i zmieniamy go wyłączamy.


Informacje o monologach ******dokończyć*******

Informacje o drzwiach wyjsciownych ******dokończyć*******




Źródła

Assety z unity asset Store:
- Basic Motions FREE - KEVIN IGLASIAS
- Pxltiger Zombie
- FREE Rigged Skeleton and Bone Collection - Ferocious Industries
- Hospital Horror Pack - FoeJofMay
- FirstPerson AIO - Aedan Graves
- Horror Elements - Anthon
- Handpainted Keys - RoboCD
- Metal Door - SimViz
- Clipboard - cookiepopworks.com

Dodatkowe filmiki (oprócz zajęć i wykładów):
- https://www.youtube.com/watch?v=ZB18V47P1y0
- https://www.youtube.com/watch?v=EciYWWDIgB8
- https://www.youtube.com/watch?v=eQphjWreQ0U
- https://www.youtube.com/watch?v=qk2faPstZK0
- https://www.youtube.com/watch?v=TAGZxRMloyU
- https://www.youtube.com/watch?v=hEth0drTuyg
- https://www.youtube.com/watch?v=UVUMqss4A34
- https://www.youtube.com/watch?v=Z5Wm-WZi0g8

+ Google

Inne: 
https://vlipsy.com/vlip/the-bells-jump-scare-CiuPrJtA
https://sketchfab.com/3d-models/samara-the-ring-57ab1a21d63744dfab12c54c7d139ddb
