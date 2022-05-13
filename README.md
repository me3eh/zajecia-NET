# zajecia-NET

[Zadanie 1](https://github.com/me3eh/zajecia-NET/tree/zad_1 "Zadanko 1")
***
[Zadanie 2](https://github.com/me3eh/zajecia-NET/tree/zad_2 "Zadanko 2")
***
[Zadanie 3](https://github.com/me3eh/zajecia-NET/tree/zad_3_domowe "Zadanko 3")
***
[Zadanie 4](https://github.com/me3eh/zajecia-NET/tree/zad_4_domowe "Zadanko 4")

Zmodyfikuj aplikację webową Lata przestępne w taki sposób, aby:
- użytkownik może podać dodatkowo opcjonalne pole nazwisko. Każde zwalidowane wyszukanie (rok, imię, nazwisko, data i godzina oraz wynik) zostało zapisane w bazie danych (1 pkt)
- na stronie “Ostatnio szukane” była dostępna lista 20 ostatnich wyszukiwań posortowanych malejąco według czasu (0.5pkt)
- aplikacja powinna udostępnić możliwość usunięcia wpisu z historii, a edycja historycznych wpisów nie powinna być dostępna (0.25pkt)
Ponadto:
- Aplikacja nadal powinna realizować zapis danych do sesji. Odczyt z sesji powinien być dostępny na stronie “Zapisane w sesji” (0.25pkt)
***
[Zadanie 5](https://github.com/me3eh/zajecia-NET/tree/zad_5_serwisy "Zadanko 5")

Rozszerz aplikację webową lata przestępne o następujące kroki:

1. Usuń zapis i odczyt z sesji (0.1 pkt)

2. Zrefaktoryzuj kod w taki sposób, aby zapis i odczyt danych z bazy realizowany był za pomocą serwisu implementującego interface i zawierający metody:

AddEntry() - dodaje wpis do bazy danych

GetAllEntries() - zwraca wszystkie rekordy z bazy danych

GetEntriesFromToday() - zwraca listę rekordów zapisanych w bieżącym dniu

Implementacja serwisów i interface'sów - 0.75pkt

Implementacja odczytu i zapisu. Przy zapisie imię i nazwisko powinno być wyświetlane jako jedna właściwość. - 0.75pkt

3. Wywołaj poszczególne metody na odpowiednich stronach:

IndexModel powinno wywoływać GetEntriesFromToday() -0.1pkt
Strona z historycznymi wpisami powinna zawierać pełną listę wpisów - 0.1pkt

4. Uspójnij nazewnictwo: 0.2pkt
***
[Zadanie 6](https://github.com/me3eh/zajecia-NET/tree/zad_6_identity_claims "Google's Homepage")

 Zmodyfikuj kod aplikacji www Lata przestępne, w taki sposób, aby:

- projekt obsługiwał rejestrację, logowanie i wylogowywanie użytkowników (0.25 pkt)

- strona ‘Ostatnio szukane’ (wpisy z bazy danych) była dostępna tylko dla zalogowanych użytkowników (0.25 pkt)

- zalogowany użytkownik na stronie ‘Ostatnio szukane’ (wpisy z bazy danych) widzi 20 ostatnich dodanych wyszukiwań, ale może usuwać tylko wpisy dodane przez siebie (0.5 pkt)

W serwisie CEZ umieść link do repozytorium kodu.
***
[Zadanie 7](https://github.com/me3eh/zajecia-NET/tree/zadanie_z_middleware'm "Zadanie 7")

Utwórz własny middleware
- [x] 0.5pkt dla IApplicationBuilder 

lub

- [ ] 0.25pkt dla postaci zanonimizowanej), 

który:


- [ ] wariant 1: 0.25pkt

wypisuje na stronie WWW zawartość zmiennej User-Agent zapisanej w nagłówkach żądania (zmienna Request.Headers w kontekście)

lub

- [x] wariant 2: 0.5pkt

sprawdza nazwę przeglądarki. Dla przeglądarek: Edge, EdgeChromium i IE middleware zwraca przekierowanie na stronę: https://www.mozilla.org/pl/firefox/new/ .

W przypadku innych przeglądarek użytkownik powinien otrzymać  żądaną stronę. 

W celu sprawdzanie nazwy przeglądarki z której wysłane jest żądanie możesz użyć zewnętrznego pakietu.

