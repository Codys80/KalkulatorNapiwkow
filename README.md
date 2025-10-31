# Kalkulator Napiwków
## Opis zadania  
Należy przygotować aplikację mobilną w środowisku **.NET MAUI** o nazwie **„Kalkulator Napiwków”**, która umożliwi użytkownikowi obliczenie wysokości napiwku w restauracji oraz łącznej kwoty rachunku.  

---

## Wymagane elementy interfejsu  
- **Nagłówek aplikacji** – Label z tekstem: „Kalkulator Napiwków”  
- **Opis** – Label z tekstem: „Kwota rachunku:”  
- **Pole tekstowe (Entry)** – do wpisania kwoty rachunku  
- **Etykieta informacyjna** – Label z tekstem: „Procent napiwku:”  
- **Suwak (Slider)** – wybór wartości od 0% do 30%  
- **Wyświetlacz procentu** – Label pokazujący aktualnie wybrany procent (np. „15%”)  
- **Przycisk „Oblicz napiwek”** – oblicza wartości  
- **Wynik napiwku** – Label pokazujący kwotę napiwku  
- **Wynik łączny** – Label pokazujący łączną kwotę do zapłaty  
- **Przycisk „Wyczyść”** – resetuje dane w aplikacji  

---

## Działanie aplikacji  
### Funkcja podstawowa  
Po kliknięciu przycisku **„Oblicz napiwek”**:  
- Pobierana jest kwota z pola tekstowego  
- Odczytywany jest procent napiwku z suwaka  
- Obliczane są wartości według wzorów:  
  - napiwek = kwota × (procent / 100)  
  - łącznie = kwota + napiwek  
- Wyniki są wyświetlane w odpowiednich polach  

### Funkcja dodatkowa  
- Podczas przesuwania suwaka aktualizuje się etykieta z procentem napiwku  
- Po kliknięciu **„Wyczyść”**:  
  - Czyszczone są pola tekstowe  
  - Suwak wraca do wartości domyślnej (np. 15%)  
  - Wyniki zostają usunięte  

---

## Wymagania techniczne  

### Interfejs użytkownika  
- Format interfejsu: **XAML**  
- Układ: **VerticalStackLayout**  
- Marginesy strony: **20 jednostek**  
- Odstępy między elementami: **15 jednostek**

### Kolorystyka i styl  
- Tło aplikacji: `#F5F5F5` (jasnoszare)  
- Kolor nagłówka: `#2196F3` (niebieski)  
- Styl nagłówka:  
  - Czcionka: **28**, **Bold**, kolor biały  
  - Tło: niebieskie (`#2196F3`), padding: 20  

- **Przyciski:**  
  - „Oblicz napiwek” – tło `#4CAF50` (zielone), tekst biały  
  - „Wyczyść” – tło `#FF9800` (pomarańczowe), tekst biały  
  - Minimalna wysokość: 50 jednostek  

- **Wyniki:**  
  - Czcionka: 20, **Bold**, kolor `#1976D2` (ciemny niebieski)

---

## Konfiguracja kontrolek  
- **Entry (pole tekstowe):**  
  - Keyboard: **Numeric**  
  - Placeholder: „Wpisz kwotę”  

- **Slider (suwak):**  
  - Minimum: 0  
  - Maksimum: 30  
  - Wartość początkowa: 15  

---

## Obliczenia i walidacja  
- Wyniki zaokrąglone do **dwóch miejsc po przecinku**  
- Format wyświetlania:  
  - `Napiwek: XX.XX zł`  
  - `Do zapłaty: XX.XX zł`  
- Obsługa błędów: aplikacja powinna reagować na brak danych lub błędne wartości  

---

## Wymagania jakościowe  
- Kod powinien być czytelny i zgodny z zasadami **czystego formatowania**  
- Nazwy zmiennych i metod powinny być znaczące, np. `CalculateTip()`, `ClearFields()`  
- Obsługa zdarzeń powinna być poprawna i odporna na błędy  
- Powinna istnieć **podstawowa walidacja danych wejściowych**  

---

## Dokumentacja – Zrzuty ekranu  
W folderze `[numer_zdającego]/mobilna/` należy umieścić zrzuty ekranu:  
1. **mobilna1.jpg** – widok początkowy aplikacji (puste pola)  
2. **mobilna2.jpg** – po wpisaniu kwoty i zmianie suwaka (przed obliczeniem)  
3. **mobilna3.jpg** – po kliknięciu „Oblicz napiwek”  
4. **mobilna4.jpg** – po kliknięciu „Wyczyść”  

Jeśli aplikacja nie uruchamia się:  
- **mobilna.jpg** – zrzut z błędami kompilacji, kodem i paskiem zadań  

---

## Wskazówki dla początkujących  
- Zacznij od utworzenia interfejsu w XAML  
- Nadaj kontrolkom nazwy (x:Name)  
- Użyj `double.TryParse()` do konwersji danych  
- Użyj `.ToString("F2")` dla formatowania  
- Zaimplementuj `ValueChanged` dla suwaka  
- Dla lepszej oceny:  
  - Dodaj walidację z komunikatami błędów  
  - Aktualizuj wyniki „na żywo”  
  - Dodaj wybór waluty (zł, €, $)  
  - Zapamiętuj ostatni procent napiwku  
