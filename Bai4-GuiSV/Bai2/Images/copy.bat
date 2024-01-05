del "%cd%\Arena\P1.exe"
del "%cd%\Arena\P2.exe"

copy "%cd%\Bots\C++\C++Template\2015_Debug\AI_Template.exe" "%cd%\Arena\P1.exe"
copy "%cd%\Bots\C++\C++Template\2015_Debug\AI_Template.exe" "%cd%\Arena\P2.exe"

call "P1-vs-P2.bat"