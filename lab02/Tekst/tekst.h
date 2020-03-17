const char NazwaProgramu[] = "test";
const int MaxX = 400;
const int MaxY = 300;
HFONT hFont;

void Rysuj(HDC hdc, int x, int y, int kolor){
	SetBkColor(hdc, 0xEEEEEE);
	SetTextColor(hdc, kolor);
	static LOGFONT lf;
	lf.lfHeight = 25;
	lf.lfEscapement = 0;
	lstrcpy (lf.lfFaceName, TEXT ("Times New Roman CE"));
	hFont = CreateFontIndirect(&lf);
	SelectObject(hdc, hFont);
	TextOut(hdc, x, 1+y, "Ma³gorzata Skucha",17);
	DeleteObject(hFont);
}