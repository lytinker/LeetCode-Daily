using System.Collections.Generic;

public class Node {
    public int val;
    public IList<Node> neighbors;
    
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
    
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}


public class Solution {
    private Dictionary<int, Node> _map;

    public Node CloneGraph(Node node) {
        if(node == null) {
            return null;
        }
        
        _map = new Dictionary<int, Node>();

        return CloneNode(node);
    }

    private Node CloneNode(Node node) {
        if(_map.TryGetValue(node.val, out var result)) {
            return result;
        }

        var newNode = new Node(node.val);
        _map.Add(node.val, newNode);
        foreach(var neighbor in node.neighbors) {
            var newNeighbor = CloneNode(neighbor);
            newNode.neighbors.Add(newNeighbor);
        }

        return newNode;
    }
}