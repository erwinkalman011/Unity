# Tema Unity - Grafica Digitala

## Exercitiul 1 si 2

- Am creat o scena 3D cu plane-uri texturate (pereti + podea + tavan)
- Am adaugat doua cuburi cu componente `Rigidbody` si `BoxCollider`
- Cuburile sunt pozitionate la inaltime si afectate de gravitatie
- La rularea scenei, acestea cad si se opresc pe podea

---

## Exercitiul 3

- Am creat un script C# numit `MiscareCub1.cs`, aplicat pe cubul 1
- Scriptul consine o miscare folosind `Transform.Translate(...)`
- Cand miscarea este implementata in functia Start(), cubul se deplaseaza o singura data la pornirea scenei, cu o distanta fixa
- Cand miscarea este implementata in functia Update(), cubul se misca in mod repetat, cate putin, la fiecare cadru. Astfel, miscarea este continua, dar viteza depinde de numarul de cadre pe   
  secunda (FPS)

---

## Exercitiul 6

- Cubul aflat in miscare intra pana in mijlocul cubului static si il impinge la dreapta, dar la a doua coliziune cubul static nu mai este impins cu aceeasi putere

---

## Exercitiul 9

- Comportamentul obiectelor in modul Play:
  Sfera trece prin plante fara sa le afecteze, deoarece acestea sunt setate ca kinematic - nu raspund la forte fizice.