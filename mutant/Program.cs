
Mutant mutant = new Mutant(2,3);
mutant.arms[0].hands[0].fingers[0].Bend();
mutant.arms[0].hands[0].fingers[1].Bend();
mutant.arms[0].hands[0].fingers[2].Bend();
mutant.arms[0].hands[0].fingers[3].Bend();

for(int i = 0; i < 100; i++){
    int rnd = new Random().Next(1, 4);
    new Mutant(rnd, rnd);
}