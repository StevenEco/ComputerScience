# 深度优先搜索题

## 树形深搜

### leetcode #98 Validate Binary Search Tree

给定一个二叉树，确定是否是BST，返回true或false

例如：

``` shell
Example 1:

    2
   / \
  1   3

Input: [2,1,3]
Output: true

Example 2:

    5
   / \
  1   4
     / \
    3   6

Input: [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
```

解题思路：
很显然使用递归的方式进行处理，需要注意的是边界值。重点就是保存上一个值的大小。

``` C#
private long temp = long.MinValue;
public bool IsValid(TreeNode tree)
{
    if(tree == null)
    {
        return true;
    }
    if(IsValid(tree.left))
    {
        if(tree.val>temp)
        {
            temp = tree.val;
            return IsValid(tree.right);
        }
    }
    return false;
}
```
