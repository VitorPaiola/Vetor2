int n = int.Parse(Console.ReadLine());

int[] nums = new int[n];

string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++) {
    nums[i] = int.Parse(vet[i]);
}


for (int i = 0; i < n; i++) {
    if (nums[i] % 2 == 0) {
        Console.Write(nums[i] + " ");
    }
}

int cont = 0;
for (int i = 0; i < n; i++) {
    if (nums[i] % 2 == 0) {
        cont++;
    }
}

Console.WriteLine("\n" + cont);