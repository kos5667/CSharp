using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Part2.DataStructure {
    class Graph_Basic {
        void CreateGraph() {
            #region Graph1
            List<Vertex> v = new List<Vertex>(6) {
                new Vertex(),
                new Vertex(),
                new Vertex(),
                new Vertex(),
                new Vertex(),
                new Vertex(),
            };
            v[0].edges.Add(v[1]);
            v[0].edges.Add(v[3]);
            v[1].edges.Add(v[0]);
            v[1].edges.Add(v[2]);
            v[1].edges.Add(v[3]);
            v[3].edges.Add(v[4]);
            v[5].edges.Add(v[4]);
            #endregion

            /* 읽는 방법 : adjacent[from] -> 연결된 목록
             * 리스트를 이용한 그래프 표현
             * 메모리는 아낄 수 있지만, 접근 속도에서 손해를 본다.
             * (간선이 적고 정점이 많은 경우 이점이 있다.)
             */
            #region Graph2
            List<int>[] adjacent = new List<int>[6] {
                new List<int> {1, 3},
                new List<int> {0, 2, 3},
                new List<int> { },
                new List<int> {4},
                new List<int> { },
                new List<int> {4},
            };

            List<Edge>[] adjacent2 = new List<Edge>[6] {
                new List<Edge>() { new Edge(1, 15), new Edge(3, 35) },
                new List<Edge>() { new Edge(0, 15), new Edge(2, 5), new Edge(3, 10) },
                new List<Edge>() { },
                new List<Edge>() { new Edge(4, 5) },
                new List<Edge>() { },
                new List<Edge>() { new Edge(4, 5) }
            };
            #endregion

            /* 읽는 방법 : adjacent3[from, to]
             * 행렬을 이용한 그래프 표현 (2차원 배열)
             * 메모리 소모가 심하지만, 빠른 접근이 가능하다.
             * (정점은 적고 간선이 많은 경우 이점이 있다)
             */
            #region Graph4
            int[,] adjacent3 = new int[6, 6] {
                { 0, 1, 0, 1, 0, 0 },
                { 1, 0, 1, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0 },
            };

            int[,] adjacent4 = new int[6, 6] {
                { -1, 15, -1, 35, -1, -1 },
                { 15, -1, 5, 10, -1, -1 },
                { -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, 5, -1 },
                { -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, 5, -1 },
            };
            #endregion
        }
    }

    class Vertex {
        public List<Vertex> edges = new List<Vertex>();
    }

    class Edge {
        public Edge(int v, int w) { vertex = v; weight = w; }
        public int vertex;
        public int weight;
    }
}
