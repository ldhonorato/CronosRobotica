#include <TimerOne.h>
#include <Ultrasonic.h>

#define TRIGGER_PIN_S0  A1//12
#define ECHO_PIN_S0     A0//13

#define TRIGGER_PIN_S1  12
#define ECHO_PIN_S1     13

#define S1_THRESHOLD  3000
#define S0_THRESHOLD  3000

#define DEBUG
//#define HARD_DEBUG

Ultrasonic ultrasonic_s0 (TRIGGER_PIN_S0, ECHO_PIN_S0);
Ultrasonic ultrasonic_s1 (TRIGGER_PIN_S1, ECHO_PIN_S1);

long sensorS0_value = 0;
long sensorS1_value = 0;

int interruptCounter = 0;

void timerCallback(void)
{
  interruptCounter++;
}

void setup() {
  Timer1.initialize(1000); //1000 us = 1 ms
  Timer1.attachInterrupt(timerCallback); // counter to run every 0.001 seconds
  Timer1.stop();
  
  Serial.begin(115200);

  interrupts();
}

// the loop routine runs over and over again forever:
void loop() {
  
  sensorS0_value = ultrasonic_s0.timing();
  delay(50);
  #if (defined DEBUG) || (defined HARD_DEBUG)
  Serial.print("S0: ");
  Serial.println(sensorS0_value);
  #endif

  #ifndef HARD_DEBUG
  if(sensorS0_value < S0_THRESHOLD)
  {
    Serial.write(0x5A);
    Timer1.start();
    do
    {
  #endif    
      sensorS1_value = ultrasonic_s1.timing();
      delay(50);
      #if (defined DEBUG) || (defined HARD_DEBUG)
      Serial.print("S1: ");
      Serial.println(sensorS1_value);
      #endif
  #ifndef HARD_DEBUG    
    }while(sensorS1_value > S1_THRESHOLD);

  
    Serial.write(0xA5);
    Timer1.stop();
    Serial.println("Tempo");
    Serial.print(">");
    Serial.println(interruptCounter);
    interruptCounter = 0;
  }
  #endif
}
