package Model.Negocio;

import java.text.DecimalFormat;

public class Salario {

    private Integer idSalario;
    private Integer idEmpresa;
    private DecimalFormat salarioBruto;
    private DecimalFormat salarioLiquido;
    private DecimalFormat descontoFgts;
    private DecimalFormat descontoInss;
    private Float descontoValeTransporte;
    private Float descontoValeAlimentacao;


    public Salario(){}

    public Salario(DecimalFormat salarioBruto, DecimalFormat salarioLiquido) {
        this.salarioBruto = salarioBruto;
        this.salarioLiquido = salarioLiquido;
    }

    public Salario(Integer idSalario, Integer idEmpresa, DecimalFormat salarioBruto, DecimalFormat salarioLiquido, DecimalFormat descontoFgts, DecimalFormat descontoInss, Float descontoValeTransporte, Float descontoValeAlimentacao) {
        this.idSalario = idSalario;
        this.idEmpresa = idEmpresa;
        this.salarioBruto = salarioBruto;
        this.salarioLiquido = salarioLiquido;
        this.descontoFgts = descontoFgts;
        this.descontoInss = descontoInss;
        this.descontoValeTransporte = descontoValeTransporte;
        this.descontoValeAlimentacao = descontoValeAlimentacao;
    }

    public Integer getIdSalario() {
        return idSalario;
    }

    public void setIdSalario(Integer idSalario) {
        this.idSalario = idSalario;
    }

    public Integer getIdEmpresa() {
        return idEmpresa;
    }

    public void setIdEmpresa(Integer idEmpresa) {
        this.idEmpresa = idEmpresa;
    }

    public DecimalFormat getSalarioBruto() {
        return salarioBruto;
    }

    public void setSalarioBruto(DecimalFormat salarioBruto) {
        this.salarioBruto = salarioBruto;
    }

    public DecimalFormat getSalarioLiquido() {
        return salarioLiquido;
    }

    public void setSalarioLiquido(DecimalFormat salarioLiquido) {
        this.salarioLiquido = salarioLiquido;
    }

    public DecimalFormat getDescontoFgts() {
        return descontoFgts;
    }

    public void setDescontoFgts(DecimalFormat descontoFgts) {
        this.descontoFgts = descontoFgts;
    }

    public DecimalFormat getDescontoInss() {
        return descontoInss;
    }

    public void setDescontoInss(DecimalFormat descontoInss) {
        this.descontoInss = descontoInss;
    }

    public Float getDescontoValeTransporte() {
        return descontoValeTransporte;
    }

    public void setDescontoValeTransporte(Float descontoValeTransporte) {
        this.descontoValeTransporte = descontoValeTransporte;
    }

    public Float getDescontoValeAlimentacao() {
        return descontoValeAlimentacao;
    }

    public void setDescontoValeAlimentacao(Float descontoValeAlimentacao) {
        this.descontoValeAlimentacao = descontoValeAlimentacao;
    }
}
