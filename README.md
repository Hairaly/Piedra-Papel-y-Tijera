# 🪨 Piedra, Papel o Tijera - Juego en Visual Basic

Este es un proyecto simple de escritorio desarrollado en **Visual Basic .NET** usando **Windows Forms en Visual Studio**. Simula el clásico juego de Piedra, Papel o Tijera entre el usuario y la computadora.

## 🧩 Características

- Interfaz gráfica con botones para elegir piedra, papel o tijera.
- Resultado aleatorio de la computadora.
- Determinación automática del ganador.
- Contador de victorias, derrotas y empates.
- Mensajes con imágenes o íconos opcionales.

## 💻 Requisitos

- [Visual Studio 2019 o superior](https://visualstudio.microsoft.com/)
- .NET Framework 4.7.2 (o compatible)
- Sistema operativo Windows

## 📁 Estructura del proyecto

```
Piedra-Papel-y-Tijera
├── Form1.vb
└── README.md
```

## ▶️ Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tuusuario/PiedraPapelTijeraVB.git
   ```
2. Abre el archivo `.sln` en Visual Studio.
3. Presiona **F5** o haz clic en **Iniciar** para compilar y ejecutar.

## 🧠 Lógica del juego (resumen)

```vb
Dim opciones() As String = {"Piedra", "Papel", "Tijera"}
Dim eleccionUsuario As String = "Piedra" ' ejemplo
Dim eleccionCPU As String = opciones(Int(Rnd() * 3))

If eleccionUsuario = eleccionCPU Then
    MsgBox("¡Empate!")
ElseIf (eleccionUsuario = "Piedra" And eleccionCPU = "Tijera") Or
       (eleccionUsuario = "Papel" And eleccionCPU = "Piedra") Or
       (eleccionUsuario = "Tijera" And eleccionCPU = "Papel") Then
    MsgBox("¡Ganaste!")
Else
    MsgBox("Perdiste.")
End If
```

## 📸 Capturas de pantalla (opcional)

_Agrega imágenes aquí del formulario y del juego funcionando._

## 📄 Licencia

Este proyecto está bajo la licencia MIT. Puedes usarlo libremente para aprender o mejorar.

