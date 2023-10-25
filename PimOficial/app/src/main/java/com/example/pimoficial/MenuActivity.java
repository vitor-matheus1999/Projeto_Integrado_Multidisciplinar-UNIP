package com.example.pimoficial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MenuActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        Button buttonTela1 = findViewById(R.id.Perfil);
        Button buttonTela2 = findViewById(R.id.Holerites);
        Button buttonTela3 = findViewById(R.id.Configuracao);

        buttonTela1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MenuActivity.this, Perfil.class);
                startActivity(intent);
            }
        });

        buttonTela2.setOnClickListener(view -> {
            Intent intent = new Intent(MenuActivity.this, Holerite.class);
            startActivity(intent);
        });

        buttonTela3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MenuActivity.this, Configuracao.class);
                startActivity(intent);
            }
        });
    }


}
