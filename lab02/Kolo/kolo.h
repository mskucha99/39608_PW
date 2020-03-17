const char NazwaProgramu[] = "naglowek";
const int MaxX = 400;
const int MaxY = 300;

void Rysuj(HDC hdc, int x, int y, int promien){
Ellipse(hdc, x-promien, y-promien, x+promien, y+promien);
}