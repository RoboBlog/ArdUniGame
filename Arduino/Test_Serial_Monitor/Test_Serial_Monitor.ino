int joystick[6];
int upbut = 2;
int rightbut = 3;
int downbut = 4;
int leftbut = 5;
void setup()  
{
  Serial.begin(9600);
 
 
  pinMode(upbut,INPUT);
  digitalWrite(upbut,LOW);
  pinMode(rightbut,INPUT);
  digitalWrite(upbut,LOW);
  pinMode(downbut,INPUT);
  digitalWrite(downbut,LOW);
  pinMode(leftbut,INPUT);
  digitalWrite(leftbut,LOW);
 
}
 
 
void loop()  
{
  joystick[2] = digitalRead(upbut);
  joystick[3] = digitalRead(rightbut);
  joystick[4] = digitalRead(downbut);
  joystick[5] = digitalRead(leftbut);
  
 
    
      //Serial.print(" Up = "); 
      Serial.println(digitalRead(upbut));
      delay(100);
      //Serial.print(" Right = "); 
      //Serial.print(digitalRead(rightbut));
      //Serial.print(" Down = "); 
     // Serial.print(digitalRead(downbut));
     // Serial.print(" Left = "); 
     // Serial.println(digitalRead(leftbut));
      }
