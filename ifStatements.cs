private float money = 25.0;

public float Balance(){
    return money;
}

public float withdrawal(float amount){
    if(amount > money){
        return 0;  
    }
    else{
        money -= amount;
        return money;
    }
}

public void Deposit(float amount){
    money += amount;
}