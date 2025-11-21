# 🌀 Roll-a-Ball (Unity 3D)

## 🎮 Descripción del proyecto
Proyecto 3D desarrollado en **Unity 6.0**, dentro del módulo **Programación de Lenguajes Gráficos (PLG – 3ºDAM)**.  
El jugador controla una esfera que se desplaza por un área recogiendo cubos (“PickUps”), con posibilidad de salto, cambio de niveles, reinicio de partida y detección de caída.  

Incluye un menú principal, música ambiental, detección de colisiones, puntuación dinámica y un panel final con botones funcionales (**Restart**, **Exit** y **Next Level**).

---

<h1>NOTA IMPORTANTE</h1>

El proyecto se ha realizado con *UNITY* en su **versión 6.0 (6000.0.61f1)**
Es necesario descargarse esta versión para poder ejecutar el proyecto de manera correcta.



## 🚀 Comenzando

Estas instrucciones te permitirán obtener una copia del proyecto para pruebas o evaluación académica.

### 📁 Estructura del proyecto
El proyecto consta de las siguientes escenas principales:

1. **IntroPanel** → Menú principal con botón “Start Game”.
2. **Level01** → Nivel base (tutorial extendido Roll-a-Ball).
3. **Level02** → Segundo nivel con plataformas y dificultad avanzada.

---

## 📋 Pre-requisitos

Antes de comenzar, asegúrate de tener instalado:

- 🧩 **Unity 6.0 o superior** → [Descargar Unity Hub](https://unity.com/download)
- 💻 **Visual Studio Community** con soporte C# y herramientas de Unity
- 🔧 **Git** → [https://git-scm.com/downloads](https://git-scm.com/downloads)

---

## ⚙️ Tecnologías utilizadas

- **Unity 6.0** – Motor de desarrollo 3D
- **C# (Visual Studio)** – Programación del comportamiento del jugador y la lógica del juego
- **TextMeshPro (TMP)** – Interfaz de usuario y marcador de puntuación
- **Input System** – Control de movimiento y salto
- **SceneManager API** – Cambio de escenas y niveles
- **Audio Source** – Reproducción de música ambiental
- **GitHub** – Control de versiones y entrega del proyecto


## 🔧 Instalación

### 1️⃣ Clonar el repositorio

git clone `https://github.com/Edu-Estevez-Lemes/pglUT04_RollaBall.git`

### 2️⃣ Abrir el proyecto

Abre Unity Hub → “**Open Project**”.

Selecciona la carpeta clonada *pglUT04_RollaBall*.

Espera a que se importen los assets y dependencias.

### 3️⃣ Ejecutar el juego

Escena inicial: IntroPanel
(Debe estar en la primera posición en “File → Build Settings → Scenes In Build”)

Pulsa Play o genera el Build del juego.

## ⚙️ Características principales
| **Funcionalidad**	                 |                            **Descripción** |
|------------------------------------|--------------------------------------------|
| 🎮 Movimiento del jugador	        |        Control con teclado mediante Input System (**WASD**)  |
| 🌀 Salto	                        |        Barra espaciadora con detección de suelo (**Raycast**)  |
| 🎯 Recolectables (PickUps)	    |        Cubos con “Is Trigger” que otorgan puntos  |
| 📊 Contador de puntuación	        |       UI dinámica que se actualiza en tiempo real  |
| 🔄 Panel de fin de partida	    |        Botones Restart / Exit / Next Level funcionales  |
| 🪂 Detección de caída	            |        Si la bola cae fuera del tablero, se muestra el panel final **EXIT** o **RESTART**  |
| 🎵 Música ambiental	            |        Reproducción automática al iniciar el primer nivel nivel  |
| 🔁 Cambio de niveles	            |        Transición de Level01 → Level02 con el botón **NEXT LEVEL** al cumplir el objetivo  |
| 🧱 Obstáculos y plataformas	    |        Añadidos en Level02 para aumentar la dificultad  |
| 🕹️ Menú principal	             |        Escena inicial con botón “**Start Game**”  |

## 🧩 Scripts principales
| **Script**	                 |               **Función** |
|--------------------------------|------------------------------------------------------------------------|
|PlayerController.cs	         |               Control del jugador, movimiento, salto, puntuación y UI  |
|MusicManager.cs	             |               Control del audio ambiental persistente  |
|MainMenu.cs	                 |               Gestión del menú inicial y carga de Level01  |
|CameraController.cs	         |               Seguimiento de la cámara al objeto Player  |

## 🎵 Audio

- Carpeta: `/Assets/Audio/soundtrack.mp3`
- Configuración: Reproducción automática con Play On Awake habilitado.

## 🎨🧱 Texturas

- En el **Level 2** he añadido texturas al escenario. En la carpeta *Materials* se encuentra un directorio con archivos `jpg` con las texturas.
- El **Level 1** se ve como en los tutoriales y así ver la diferencia entre ambos escenarios.

## 🧪 Pruebas realizadas
| **Prueba**	          |      **Resultado esperado**  |
|-------------------------|------------------------------|
| Recoger cubos	          |      Incrementa el contador y desactiva el cubo  |
| Saltar	              |      La bola se eleva con espacio y cae correctamente  |
| Caer fuera del mapa	  |      Se activa el EndPanel con Restart/Exit  |
| Botón Next Level	      |      Carga correctamente Level02  |
| Restart	              |      Reinicia la escena actual  |
| Exit	                  |      Cierra el juego o detiene el modo Play (en el editor)  |

## 🔥VR EJEMPLO

Dentro de la carpeta Scenes, hay una escena llamada **Level01VR**.
Una esacena desarrollada como prueba VR.
### Los paquetes descargados han sido:

- XR Interaction Toolkit y samples Starter Assets y XR Device Simulator
- XR Plugin Management
- OpenXR Plugin

Podemos arrastrar la bola por el tablero para que atrape los PickUps.

## ✒️ Autor
**Eduardo Estévez Lemes**
- 🎓 Estudiante de Desarrollo de Aplicaciones Multiplataforma (3º DAM)
- 📘 Módulo: PGL 
- 💻 Motor: Unity 6.0 – Lenguaje C#

## 📜 Licencia

Proyecto académico con fines educativos dentro del módulo Programación de Lenguajes Gráficos (PLG).
Uso libre para aprendizaje y prácticas personales en Unity.
