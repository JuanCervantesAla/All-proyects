/*
Cervantes Alatorre Juan José Emiliano
18300645
7B1
24/08/2021
*/

//Variables utilizadas
int motorAdelante =6 ;
int motorAtras = 5;
int frAdelante = A1;
int lm35 = A0;
float valor = 0;
int pinEnable = 11;
int pwm;

void setup()
{
  //Declaración de cada modo de los pines
  pinMode(pinEnable,OUTPUT);
  pinMode(frAdelante,INPUT);
  pinMode(lm35,INPUT);
  pinMode(motorAdelante,OUTPUT);
  pinMode(motorAtras,OUTPUT);
} 
  
void loop()
{    
      //Toma el valor en bits del potenciometro
      valor = analogRead(lm35);
      //Asignación del porcentaje 
      pwm = map(valor,0,1023,0,255);
      //Toma de decisiones 
        if(digitalRead(frAdelante)==HIGH){
          //Resultado de la desición
          digitalWrite(motorAdelante,HIGH);
          digitalWrite(motorAtras,LOW);
          analogWrite(pinEnable,pwm);
          delay(50);
        }
      else{
          digitalWrite(motorAdelante,LOW);
          digitalWrite(motorAtras,HIGH);
          analogWrite(pinEnable,pwm);
          delay(50);
        }
        
  delay(50);
}
