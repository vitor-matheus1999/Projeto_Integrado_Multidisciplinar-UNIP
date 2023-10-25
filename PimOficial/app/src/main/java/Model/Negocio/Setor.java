package Model.Negocio;

import java.sql.Time;
import java.text.DecimalFormat;

public class Setor {

    private Integer idSetor;
    private Integer idEmpresa;
    private Integer idSalario;
    private String nomeSetor;
    private String hierarquia;
    private String funcaoSetor;
    private String periodoTrabalho;
    private String escalaTrabalho;
    private Time cargaHoraria;
    private DecimalFormat salarioGanhoHora;
    private DecimalFormat salarioGanhoDia;

    public Setor() {
    }

    public Setor(Integer idSetor, Integer idEmpresa, Integer idSalario, String nomeSetor, String hierarquia, String funcaoSetor, String periodoTrabalho, String escalaTrabalho, Time cargaHoraria, DecimalFormat salarioGanhoHora, DecimalFormat salarioGanhoDia) {
        this.idSetor = idSetor;
        this.idEmpresa = idEmpresa;
        this.idSalario = idSalario;
        this.nomeSetor = nomeSetor;
        this.hierarquia = hierarquia;
        this.funcaoSetor = funcaoSetor;
        this.periodoTrabalho = periodoTrabalho;
        this.escalaTrabalho = escalaTrabalho;
        this.cargaHoraria = cargaHoraria;
        this.salarioGanhoHora = salarioGanhoHora;
        this.salarioGanhoDia = salarioGanhoDia;
    }

    public Integer getIdSetor() {
        return idSetor;
    }

    public void setIdSetor(Integer idSetor) {
        this.idSetor = idSetor;
    }

    public Integer getIdEmpresa() {
        return idEmpresa;
    }

    public void setIdEmpresa(Integer idEmpresa) {
        this.idEmpresa = idEmpresa;
    }

    public Integer getIdSalario() {
        return idSalario;
    }

    public void setIdSalario(Integer idSalario) {
        this.idSalario = idSalario;
    }

    public String getNomeSetor() {
        return nomeSetor;
    }

    public void setNomeSetor(String nomeSetor) {
        this.nomeSetor = nomeSetor;
    }

    public String getHierarquia() {
        return hierarquia;
    }

    public void setHierarquia(String hierarquia) {
        this.hierarquia = hierarquia;
    }

    public String getFuncaoSetor() {
        return funcaoSetor;
    }

    public void setFuncaoSetor(String funcaoSetor) {
        this.funcaoSetor = funcaoSetor;
    }

    public String getPeriodoTrabalho() {
        return periodoTrabalho;
    }

    public void setPeriodoTrabalho(String periodoTrabalho) {
        this.periodoTrabalho = periodoTrabalho;
    }

    public String getEscalaTrabalho() {
        return escalaTrabalho;
    }

    public void setEscalaTrabalho(String escalaTrabalho) {
        this.escalaTrabalho = escalaTrabalho;
    }

    public Time getCargaHoraria() {
        return cargaHoraria;
    }

    public void setCargaHoraria(Time cargaHoraria) {
        this.cargaHoraria = cargaHoraria;
    }

    public DecimalFormat getSalarioGanhoHora() {
        return salarioGanhoHora;
    }

    public void setSalarioGanhoHora(DecimalFormat salarioGanhoHora) {
        this.salarioGanhoHora = salarioGanhoHora;
    }

    public DecimalFormat getSalarioGanhoDia() {
        return salarioGanhoDia;
    }

    public void setSalarioGanhoDia(DecimalFormat salarioGanhoDia) {
        this.salarioGanhoDia = salarioGanhoDia;
    }
}
