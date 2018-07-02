class Human {
  private double totalBudget;
  private string name;

  public void setName(string newName) {
    name = newName;
  }

  public void setTotalBudget(string newTotalBudget) {
    totalBudget = newTotalBudget;
  }

  public double lend(double money) {
    if (money <= totalBudget) {
      totalBudget -= money;
      return money;
    } else {
      MessageBox.Show("Do not have enough money");
      return 0;
    }
  }

  public void borrow(double money) {
    totalBudget += money;
  }
}
