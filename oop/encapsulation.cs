class Circulo {
  private double radio;

  public void setRadio(double newRadioValue) {
    if (newRadioValue > 0) {
      radio = newRadioValue;
    } else {
      MessageBox.Show("Radio greater than zero!");
    }
  }
}
