class Person {
  private string name;

  public void setName(string newName) {
    this.name = newName;
  }

  public void getName() {
    return name;
  }
}

class LegalPerson : Person {
  private string cnpj;

  public void setCnpj(string newCnpj) {
    this.cnpj = newCnpj;
  }

  public void getCnpj() {
    return cnpj;
  }
}

class PhysicalPerson : Person {
  private string cpf;

  public void setCpf(string newCpf) {
    this.cpf = newCpf;
  }

  public void getCpf() {
    return cpf;
  }
}
