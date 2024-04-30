using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeetcodeApplication
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public class TreeBuilder
    {
        public TreeNode BuildTree(List<int> values)
        {
            if (values == null || values.Count == 0 || values[0] == -1)
                return null;

            TreeNode root = new TreeNode(values[0]);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 1;

            while (queue.Count > 0 && index < values.Count)
            {
                TreeNode current = queue.Dequeue();
                if (values[index] != -1)
                {
                    current.left = new TreeNode(values[index]);
                    queue.Enqueue(current.left);
                }
                index++;
                if (index < values.Count && values[index] != -1)
                {
                    current.right = new TreeNode(values[index]);
                    queue.Enqueue(current.right);
                }
                index++;
            }

            return root;
        }

        public void PrintTree(TreeNode root)
        {
            PrintTree(root, 0);
        }

        private void PrintTree(TreeNode node, int depth)
        {
            if (node == null)
                return;

            Console.WriteLine($"{node.val}");
            PrintTree(node.left, depth + 1);
            PrintTree(node.right, depth + 1);
        }

        public async Task<int> MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int depth = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                int sz = queue.Count;
                while (sz != 0)
                {
                    TreeNode node = queue.Dequeue();

                    if (node.left == null && node.right == null)
                        return depth;

                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);

                    sz--;
                }
                depth++;
            }

            await Task.Delay(0);

            return depth;
        }
    }
}
