# LostSong
LostSong to aplikacja do rozpoznawania "zagubionych" plików muzycznych na naszym komputerze. Dzięki integracji z API [AcousticID](https://acoustid.org), pomoże ona zidentyfikować i otagować pliki muzyczne na bazie ich zawartości, nawet jeśli plik nie ma metadanych.

# Wymagania aplikacji desktopowej
•Obsługa formatów MP3/WAV.<br/>
•Rozpoznanie tytułu pliku muzycznego dzięki zewnętrznemu serwisowi AcousticID.<br/>
•Tagowanie metadanych pliku (Tytuł, Artysta, Album, Data wydania...) na bazie zawartości pliku. <br/>

Główną metodą działania aplikacji LostSong, jest wygenerowanie "hashu" danego utworu muzycznego za pomocą algorytmu **chromaprint** [Chromaprint](https://github.com/acoustid/chromaprint), a następnie przeszukanie bazy danych serwisu AcousticID, aby znaleźć otagowane już utwory z podobnym "hashem".

# Używane serwisy i biblioteki

∙ [NAudio](https://github.com/naudio/NAudio) - procesowanie plików audio.<br/>
∙ [AcousticID.NET](https://github.com/wo80/AcoustID.NET) - tworzenie "hashu" danego pliku muzycznego.<br/>
∙ [Taglib-sharp](https://github.com/mono/taglib-sharp) - tagowanie pliku muzycznego.<br/>
