# 🪨 Piedra, Papel o Tijera - Juego en Visual Basic
Este es un proyecto simple de escritorio desarrollado en Visual Basic .NET utilizando Windows Forms en Visual Studio. El programa simula el clásico juego de Piedra, Papel o Tijera, permitiendo al usuario competir contra la computadora de forma interactiva.

Al iniciar el juego, el usuario puede seleccionar una de las tres opciones (piedra, papel o tijera) mediante botones gráficos, mientras que la computadora elige aleatoriamente su jugada. El sistema evalúa ambas elecciones y muestra el resultado de la ronda (ganas, pierdes o empatas), acompañado de mensajes visuales y contadores de puntuación.

## 🧩 Características

- Interfaz gráfica con botones para elegir piedra, papel o tijera.
- Resultado aleatorio de la computadora.
- Determinación automática del ganador.


## 💻 Requisitos

- [Visual Studio 2019 o superior](https://visualstudio.microsoft.com/)
- .NET Framework 4.7.2 (o compatible)
- Sistema operativo Windows

## 📁 Estructura del proyecto

```
Piedra-Papel-y-Tijera
├── Piedra_Papel y Tijera.vb
└── README.md
```

## ▶️ Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Hairaly/Piedra-Papel-y-Tijera.git
   ```
2. Abre el archivo `.sln` en Visual Studio.
3. Presiona **F5** o haz clic en **Iniciar** para compilar y ejecutar.

## 🧠 Lógica del juego 

```vb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario As Integer = 0
        Dim sistema As Integer = 0
        Dim Rnd As New Random()

    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged

        If RadioButton1.Checked Then
            TextBox1.Text = "✊"
        ElseIf RadioButton2.Checked Then
            TextBox1.Text = "🖐️"
        ElseIf RadioButton3.Checked Then
            TextBox1.Text = "✌️"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Rnd As New Random()
        Dim sistema As Integer = Rnd.Next(1, 4)

        Select Case sistema
            Case 1
                TextBox2.Text = "✊"
            Case 2
                TextBox2.Text = "🖐️"
            Case 3
                TextBox2.Text = "✌️"
        End Select

        Dim resultado As String = ""
        If TextBox1.Text = TextBox2.Text Then
            resultado = "Empatamos"
        ElseIf (TextBox1.Text = "✊" And TextBox2.Text = "✌️") Or
               (TextBox1.Text = "🖐️" And TextBox2.Text = "✊") Or
               (TextBox1.Text = "✌️" And TextBox2.Text = "🖐️") Then
            resultado = "Ganaste, Felicidades"
        Else
            resultado = "Perdiste"
        End If
        MessageBox.Show(resultado, "Resultado")
    End Sub
End Class

```

## 📸 Capturas de pantalla 

<img width="430" alt="image" src="https://github.com/user-attachments/assets/0fced307-c2c4-4c51-8a39-679cb04ed081" />




