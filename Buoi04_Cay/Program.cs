using System;

namespace BinaryTreeExercises
{
    // Khai báo cấu trúc một nút trên cây nhị phân
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    // Lớp cài đặt cây nhị phân và các bài tập từ 1 đến 8
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Bài tập 1: Đếm số nút trên cây nhị phân
        public int CountNodes(Node root)
        {
            if (root == null) return 0;
            return 1 + CountNodes(root.Left) + CountNodes(root.Right);
        }

        // Bài tập 2: Tính tổng giá trị các nút trên cây nhị phân
        public int SumNodes(Node root)
        {
            if (root == null) return 0;
            return root.Data + SumNodes(root.Left) + SumNodes(root.Right);
        }

        // Bài tập 3: Hiển thị giá trị các nút trên cây nhị phân
        public void DisplayAllNodes(Node root)
        {
            if (root == null) return;
            Console.Write(root.Data + " ");
            DisplayAllNodes(root.Left);
            DisplayAllNodes(root.Right);
        }

        // Bài tập 4: Hiển thị giá trị các nút có giá trị chẵn trên cây nhị phân
        public void DisplayEvenNodes(Node root)
        {
            if (root == null) return;
            if (root.Data % 2 == 0)
            {
                Console.Write(root.Data + " ");
            }
            DisplayEvenNodes(root.Left);
            DisplayEvenNodes(root.Right);
        }

        // Bài tập 5: Đếm số lượng nút có giá trị chẵn trên cây nhị phân
        public int CountEvenNodes(Node root)
        {
            if (root == null) return 0;
            int count = (root.Data % 2 == 0) ? 1 : 0;
            return count + CountEvenNodes(root.Left) + CountEvenNodes(root.Right);
        }

        // Bài tập 6: Đếm số con của một nút trên cây nhị phân
        public int CountChildren(Node targetNode)
        {
            if (targetNode == null) return 0;
            int count = 0;
            if (targetNode.Left != null) count++;
            if (targetNode.Right != null) count++;
            return count;
        }

        // Bài tập 7: Hiển thị giá trị các nút trên cây con trái của cây nhị phân
        public void DisplayLeftSubtree()
        {
            if (Root == null || Root.Left == null)
            {
                Console.Write("Cay con trai rong.");
                return;
            }
            DisplayAllNodes(Root.Left);
        }

        // Bài tập 8: Duyệt cây nhị phân theo các thứ tự
        // 8a. Tiền thứ tự (Node - Left - Right)
        public void PreOrder(Node root)
        {
            if (root == null) return;
            Console.Write(root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        // 8b. Trung thứ tự (Left - Node - Right)
        public void InOrder(Node root)
        {
            if (root == null) return;
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }

        // 8c. Hậu thứ tự (Left - Right - Node)
        public void PostOrder(Node root)
        {
            if (root == null) return;
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root.Data + " ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(20);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(8);
            tree.Root.Right.Right = new Node(15);

            Console.WriteLine("1. Tổng số nút trên cây: " + tree.CountNodes(tree.Root));
            Console.WriteLine("2. Tổng giá trị các nút: " + tree.SumNodes(tree.Root));

            Console.Write("3. Giá trị tất cả các nút: ");
            tree.DisplayAllNodes(tree.Root);
            Console.WriteLine();

            Console.Write("4. Giá trị các nút chẵn: ");
            tree.DisplayEvenNodes(tree.Root);
            Console.WriteLine();

            Console.WriteLine("5. Số lượng nút có giá trị chẵn: " + tree.CountEvenNodes(tree.Root));
            Console.WriteLine("6. Số con của nút gốc (10): " + tree.CountChildren(tree.Root));
            Console.WriteLine("   Số con của nút 20: " + tree.CountChildren(tree.Root.Right));

            Console.Write("7. Các nút trên cây con trái: ");
            tree.DisplayLeftSubtree();
            Console.WriteLine();

            Console.WriteLine("8. Duyệt cây theo các thứ tự:");
            Console.Write("   - Tiền thứ tự (NLR): ");
            tree.PreOrder(tree.Root);
            Console.WriteLine();

            Console.Write("   - Trung thứ tự (LNR): ");
            tree.InOrder(tree.Root);
            Console.WriteLine();

            Console.Write("   - Hậu thứ tự (LRN): ");
            tree.PostOrder(tree.Root);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}