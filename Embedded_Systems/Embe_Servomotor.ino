/*Cervantes Alatorre Juan José Emiliano
18300645
7B1*/

//Librerias y defines
#include<Servo.h>
#include<Adafruit_NeoPixel.h>
#define numLed 6
#define senalLed 8

//Defino el objeto pixels para las funciones de la tira led
Adafruit_NeoPixel pixels = Adafruit_NeoPixel(numLed,senalLed,NEO_GRB+NEO_KHZ800);

//Defino el objeto servo para las funciones
Servo myservo;

//Declaro variables
int const sensor=A2;
int valor;
int angle;

void setup(){
  //Inicio comunicación con la tira led
  pixels.begin();
  pixels.show();
  //Declaro al servo la salida del pin 9
  myservo.attach(9);
  Serial.begin(9600);
  
}

void loop(){
  //Declaro las variables y sus colores
  uint32_t g =  pixels.Color(0,255,0);
  uint32_t b =  pixels.Color(0,0,255);
  uint32_t r =  pixels.Color(255,0,0);
  uint32_t w =  pixels.Color(0,0,0);
  
  //Lectura del sensor
  valor= analogRead(sensor);
  angle= map(valor,0,466,0,179);
  myservo.write(angle);
  Serial.println("Angulo");
  Serial.print(angle);
  
  //Decisiones de los angulos del sensor
  
  if(angle <=90){
     pixels.setPixelColor(0,r);
    pixels.setPixelColor(1,r);
    pixels.setPixelColor(2,w);
    pixels.setPixelColor(3,w);
    pixels.setPixelColor(4,w);
    pixels.setPixelColor(5,w);
    pixels.show();
  }
  if(angle >90 && angle <=150){
     pixels.setPixelColor(0,w);
    pixels.setPixelColor(1,w);
    pixels.setPixelColor(2,b);
    pixels.setPixelColor(3,b);
    pixels.setPixelColor(4,w);
    pixels.setPixelColor(5,w);
    pixels.show();
  }
  if(angle >150 && angle <=180){
    pixels.setPixelColor(0,w);
    pixels.setPixelColor(1,w);
    pixels.setPixelColor(2,w);
    pixels.setPixelColor(3,w);
    pixels.setPixelColor(4,g);
    pixels.setPixelColor(5,g);
    pixels.show();
  }
  
  delay(15);
  
}
